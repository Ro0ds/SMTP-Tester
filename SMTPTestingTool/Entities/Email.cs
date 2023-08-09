using System.Net;
using System.Net.Mail;
using System.Text;

namespace Entities.Email
{
    internal class Email
    {
        // Recebimento
        public string ServidorEntrada { get; set; } = string.Empty;
        public int PortaEntrada { get; set; } = 0;
        public bool RequerSSL { get; set; } = false;

        // Envio
        public string ServidorSaida { get; set; } = string.Empty;
        public int PortaSMTP { get; set; } = 0;
        public string Criptografia { get; set; } = string.Empty;
        public string Remetente { get; set; } = string.Empty;
        public string SenhaDoRemetente { get; set; } = string.Empty;

        // Email
        public string Destinatario { get; set; }
        public string AssuntoDoEmail { get; set; }
        public string CorpoDoEmail { get; set; }

        // Log
        public StringBuilder Log { get; set; } = new StringBuilder();

        // Evento para notificar novas mensagens
        public event EventHandler<string> NovoLog;

        public Email() { }

        public Email(string servidorEntrada, int portaEntrada, bool requerSSL, string servidorSaida, int portaSMTP, string criptografia, string remetente, string senhaDoRemetente, string destinatario, string assuntoDoEmail, string corpoDoEmail)
        {
            ServidorEntrada = servidorEntrada;
            PortaEntrada = portaEntrada;
            RequerSSL = requerSSL;
            ServidorSaida = servidorSaida;
            PortaSMTP = portaSMTP;
            Criptografia = criptografia;
            Remetente = remetente;
            SenhaDoRemetente = senhaDoRemetente;
            Destinatario = destinatario;
            AssuntoDoEmail = assuntoDoEmail;
            CorpoDoEmail = corpoDoEmail;
        }

        public async Task EnviarEmailAsync()
        {
            try
            {
                using(SmtpClient smtpClient = new SmtpClient(ServidorSaida, PortaSMTP))
                {
                    if(Criptografia == "SSL/TLS" || Criptografia == "SSL")
                    {
                        smtpClient.EnableSsl = true;
                    }
                    else if(Criptografia == "TLS")
                    {
                        smtpClient.EnableSsl = false;

                        // Definindo o método de criptografia como TLS
                        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtpClient.TargetName = "STARTTLS/" + ServidorSaida;
                    }
                    else
                    {
                        smtpClient.EnableSsl = false;
                    }

                    smtpClient.Credentials = new NetworkCredential(Remetente, SenhaDoRemetente);

                    // MailMessage com informações do email em si
                    MailMessage mensagem = new MailMessage();
                    mensagem.From = new MailAddress(Remetente);
                    mensagem.To.Add(new MailAddress(Destinatario));
                    mensagem.Subject = $"SMTP TestingTool - {AssuntoDoEmail}";
                    mensagem.Body = $"{CorpoDoEmail}\n\nEsta é uma confirmação de que a configuração está correta e funcionando!\n\nSMTP TestingTool - {DateTime.Now}.";

                    // Vamos registrar o evento aqui para capturar as informações durante o envio
                    smtpClient.SendCompleted += (sender, e) => {
                        string logMsg;

                        if(e.Cancelled)
                        {
                            logMsg = $"{DateTime.Now}: Envio de email cancelado pelo usuário\n";
                        }
                        else if(e.Error != null)
                        {
                            logMsg = $"{DateTime.Now}: Erro no envio do e-mail: {e.Error.Message}\n";
                        }
                        else
                        {
                            logMsg = $"{DateTime.Now}: Email enviado com sucesso!\n";
                            InformacoesDeEnvio(Remetente, Destinatario, AssuntoDoEmail, CorpoDoEmail, DateTime.Now);
                        }

                        // Notifica que há uma nova mensagem de log
                        //LogMensagem(logMsg);
                        OnNovoLog(logMsg);

                    };

                    // setando timeout de 30s
                    smtpClient.Timeout = 30000;

                    try
                    {
                        OnNovoLog($"{DateTime.Now}: Tentando enviar email...");

                        // Envia o email
                        await smtpClient.SendMailAsync(mensagem);
                    }
                    catch(SmtpException ex)
                    {
                        if(ex.StatusCode == SmtpStatusCode.TransactionFailed)
                        {
                            throw new OperationCanceledException($"{DateTime.Now}: Envio de email cancelado pelo usuário");
                        }
                        else
                        {
                            throw ex;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro {ex.Message}.\nVerifique as informações e tente novamente mais tarde.", "Erro ao enviar Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CriarLog(ex.Message);
            }
        }

        // Metodo para acionar o evento NovoLog
        protected virtual void OnNovoLog(string mensagem)
        {
            NovoLog?.Invoke(this, mensagem);
        }

        // Remover depois?
        //private void LogMensagem(string mensagem)
        //{
        //    string logMsg = $"{DateTime.Now}: {mensagem}\n";
        //    Log.AppendLine(logMsg);
        //    OnNovoLog(logMsg);
        //}

        private void InformacoesDeEnvio(string remetente, string destinatario, string assunto, string corpoDoEmail, DateTime horario)
        {
            Log.AppendLine("************************************");
            Log.AppendLine($"Remetente: {remetente}");
            Log.AppendLine($"Destinatário: {destinatario}");
            Log.AppendLine($"Assunto: {assunto}");
            Log.AppendLine($"Mensagem: {corpoDoEmail}");
            Log.AppendLine($"Data de Envio: {horario}");
            Log.AppendLine("************************************");


            OnNovoLog(Log.ToString());
        }

        private string CriarLog(string? conteudo)
        {
            Log.AppendLine(conteudo);
            return Log.ToString();
        }

        public void LimparLog()
        {
            Log.Clear();
        }
    }
}