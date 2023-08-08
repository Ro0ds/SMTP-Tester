using Entities.Email;
using System.Windows.Forms;

namespace SMTPTestingTool
{
    public partial class Form1 : Form
    {
        private Email email;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_testar_Click(object sender, EventArgs e)
        {
            if(EstaPreenchidoCorretamente())
            {
                try
                {
                    // Recebimento
                    string ServidorEntrada = txt_servidorEntrada.Text;
                    int PortaEntrada = int.Parse(txt_portaEntrada.Text);
                    bool RequerSSL = false;

                    if(cb_requerSSL.Text.ToUpper() == "SIM")
                    {
                        RequerSSL = true;
                    }

                    // Envio
                    string ServidorSaida = txt_servidorSaida.Text;
                    int PortaSMTP = int.Parse(txt_portaSMTP.Text);
                    string Criptografia = cb_criptografia.Text;
                    string NomeDoUsuario = txt_nomeUsuario.Text;
                    string SenhaDoUsuario = txt_senhaUsuario.Text;
                    string Destinatario = txt_destinatario.Text;
                    string AssuntoEmail = txt_assunto.Text;
                    string CorpoEmail = rctxt_mensagem.Text;

                    if( !NomeDoUsuario.Contains('@') && !NomeDoUsuario.Contains('.') && !Destinatario.Contains('@') && !Destinatario.Contains('.'))
                    {
                        MessageBox.Show("E-mail com formato incorreto, revise os campos e tente novamente mais tarde!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        email = new Email(ServidorEntrada, PortaEntrada, RequerSSL, ServidorSaida, PortaSMTP, Criptografia, NomeDoUsuario, SenhaDoUsuario, Destinatario, AssuntoEmail, CorpoEmail);

                        email.NovoLog += Email_NovoLog;
                        await email.EnviarEmailAsync();
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show("Campos preenchidos incorretamente, verifique e tente novamente mais tarde.", "Erro no envio de Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Algo deu errado no envio do e-mail.\nMensagem de erro: {ex.Message}.\nExceção gerada: {ex.TargetSite}", "Erro no envio de Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                rctxt_log.AppendText("");
            }
            else
            {
                MessageBox.Show("Preencha corretamente o formulário com as informações necessárias marcadas com (*)", "Formulário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Email_NovoLog(object sender, string mensagem)
        {
            // Usa o Invoke para garantir que a atualização do RichTexBox seja feita na thread do form
            rctxt_log.Invoke((Action)(() => {
                rctxt_log.AppendText(mensagem + Environment.NewLine);
            }));
        }

        private void btn_limparLog_Click(object sender, EventArgs e)
        {
            if(rctxt_log.Text.Length == 0)
            {
                MessageBox.Show("Log não contém informações.", "Log", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                email.LimparLog();
                rctxt_log.ResetText();
            }
        }

        private bool EstaPreenchidoCorretamente()
        {
            bool foiPreenchido = true;

            foreach(Control primeiraCamada in Controls)
            {
                foreach(Control segundaCamada in primeiraCamada.Controls)
                {
                    foreach(Control txt in segundaCamada.Controls)
                    {
                        if(txt is TextBox || txt is RichTextBox || txt is ComboBox)
                        {
                            if(txt.Tag == "infoObrigatoria" && string.IsNullOrEmpty(txt.Text))
                            {
                                foiPreenchido = false;
                            }
                        }
                    }
                }
            }

            return foiPreenchido;
        }
    }
}