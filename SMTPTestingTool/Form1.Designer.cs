namespace SMTPTestingTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_limparLog = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.rctxt_mensagem = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_assunto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_destinatario = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rctxt_log = new System.Windows.Forms.RichTextBox();
            this.btn_testar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_servidorEntrada = new System.Windows.Forms.TextBox();
            this.cb_requerSSL = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_portaEntrada = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_senhaUsuario = new System.Windows.Forms.TextBox();
            this.txt_servidorSaida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_portaSMTP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_criptografia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nomeUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "SMTP Testing Tool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_limparLog);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btn_testar);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 478);
            this.panel1.TabIndex = 3;
            // 
            // btn_limparLog
            // 
            this.btn_limparLog.Location = new System.Drawing.Point(300, 446);
            this.btn_limparLog.Name = "btn_limparLog";
            this.btn_limparLog.Size = new System.Drawing.Size(263, 23);
            this.btn_limparLog.TabIndex = 15;
            this.btn_limparLog.Text = "Limpar Log";
            this.btn_limparLog.UseVisualStyleBackColor = true;
            this.btn_limparLog.Click += new System.EventHandler(this.btn_limparLog_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label);
            this.groupBox4.Controls.Add(this.rctxt_mensagem);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txt_assunto);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txt_destinatario);
            this.groupBox4.Location = new System.Drawing.Point(10, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 150);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "E-mail";
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(5, 80);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(142, 23);
            this.label.TabIndex = 15;
            this.label.Text = "(Opcional) Mensagem:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rctxt_mensagem
            // 
            this.rctxt_mensagem.Location = new System.Drawing.Point(148, 80);
            this.rctxt_mensagem.Name = "rctxt_mensagem";
            this.rctxt_mensagem.Size = new System.Drawing.Size(121, 64);
            this.rctxt_mensagem.TabIndex = 13;
            this.rctxt_mensagem.Tag = "infoOpcional";
            this.rctxt_mensagem.Text = "";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "(Opcional) Assunto:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_assunto
            // 
            this.txt_assunto.Location = new System.Drawing.Point(148, 51);
            this.txt_assunto.Name = "txt_assunto";
            this.txt_assunto.Size = new System.Drawing.Size(121, 23);
            this.txt_assunto.TabIndex = 12;
            this.txt_assunto.Tag = "infoOpcional";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "* Destinatário:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_destinatario
            // 
            this.txt_destinatario.Location = new System.Drawing.Point(148, 22);
            this.txt_destinatario.Name = "txt_destinatario";
            this.txt_destinatario.Size = new System.Drawing.Size(121, 23);
            this.txt_destinatario.TabIndex = 11;
            this.txt_destinatario.Tag = "infoObrigatoria";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rctxt_log);
            this.groupBox3.Location = new System.Drawing.Point(300, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 434);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // rctxt_log
            // 
            this.rctxt_log.Location = new System.Drawing.Point(6, 20);
            this.rctxt_log.Name = "rctxt_log";
            this.rctxt_log.ReadOnly = true;
            this.rctxt_log.Size = new System.Drawing.Size(251, 408);
            this.rctxt_log.TabIndex = 9999;
            this.rctxt_log.Text = "";
            // 
            // btn_testar
            // 
            this.btn_testar.Location = new System.Drawing.Point(10, 446);
            this.btn_testar.Name = "btn_testar";
            this.btn_testar.Size = new System.Drawing.Size(274, 23);
            this.btn_testar.TabIndex = 14;
            this.btn_testar.Text = "Enviar E-mail";
            this.btn_testar.UseVisualStyleBackColor = true;
            this.btn_testar.Click += new System.EventHandler(this.btn_testar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_servidorEntrada);
            this.groupBox2.Controls.Add(this.cb_requerSSL);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_portaEntrada);
            this.groupBox2.Location = new System.Drawing.Point(10, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 105);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recebimento";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "* Servidor de Entrada:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_servidorEntrada
            // 
            this.txt_servidorEntrada.Location = new System.Drawing.Point(148, 20);
            this.txt_servidorEntrada.Name = "txt_servidorEntrada";
            this.txt_servidorEntrada.Size = new System.Drawing.Size(121, 23);
            this.txt_servidorEntrada.TabIndex = 1;
            this.txt_servidorEntrada.Tag = "infoObrigatoria";
            // 
            // cb_requerSSL
            // 
            this.cb_requerSSL.AutoCompleteCustomSource.AddRange(new string[] {
            "Sim",
            "Não"});
            this.cb_requerSSL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_requerSSL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_requerSSL.FormattingEnabled = true;
            this.cb_requerSSL.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cb_requerSSL.Location = new System.Drawing.Point(148, 78);
            this.cb_requerSSL.Name = "cb_requerSSL";
            this.cb_requerSSL.Size = new System.Drawing.Size(121, 23);
            this.cb_requerSSL.TabIndex = 3;
            this.cb_requerSSL.Tag = "infoObrigatoria";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "* Porta de Entrada:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "* Requer SSL:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_portaEntrada
            // 
            this.txt_portaEntrada.Location = new System.Drawing.Point(148, 49);
            this.txt_portaEntrada.Name = "txt_portaEntrada";
            this.txt_portaEntrada.Size = new System.Drawing.Size(121, 23);
            this.txt_portaEntrada.TabIndex = 2;
            this.txt_portaEntrada.Tag = "infoObrigatoria";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_senhaUsuario);
            this.groupBox1.Controls.Add(this.txt_servidorSaida);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_portaSMTP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_criptografia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_nomeUsuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(10, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envio";
            // 
            // txt_senhaUsuario
            // 
            this.txt_senhaUsuario.Location = new System.Drawing.Point(147, 137);
            this.txt_senhaUsuario.Name = "txt_senhaUsuario";
            this.txt_senhaUsuario.PasswordChar = '*';
            this.txt_senhaUsuario.Size = new System.Drawing.Size(121, 23);
            this.txt_senhaUsuario.TabIndex = 9;
            this.txt_senhaUsuario.Tag = "infoObrigatoria";
            this.txt_senhaUsuario.UseSystemPasswordChar = true;
            // 
            // txt_servidorSaida
            // 
            this.txt_servidorSaida.Location = new System.Drawing.Point(147, 22);
            this.txt_servidorSaida.Name = "txt_servidorSaida";
            this.txt_servidorSaida.Size = new System.Drawing.Size(121, 23);
            this.txt_servidorSaida.TabIndex = 5;
            this.txt_servidorSaida.Tag = "infoObrigatoria";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "* Servidor de Saída (SMTP):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "* Porta (SMTP):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_portaSMTP
            // 
            this.txt_portaSMTP.Location = new System.Drawing.Point(147, 51);
            this.txt_portaSMTP.Name = "txt_portaSMTP";
            this.txt_portaSMTP.Size = new System.Drawing.Size(121, 23);
            this.txt_portaSMTP.TabIndex = 6;
            this.txt_portaSMTP.Tag = "infoObrigatoria";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "* Criptografia:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_criptografia
            // 
            this.cb_criptografia.AutoCompleteCustomSource.AddRange(new string[] {
            "Nenhum",
            "SSL/TLS",
            "SSL",
            "TLS (se disponível)"});
            this.cb_criptografia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_criptografia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_criptografia.FormattingEnabled = true;
            this.cb_criptografia.Items.AddRange(new object[] {
            "Nenhum",
            "SSL/TLS",
            "SSL",
            "TLS"});
            this.cb_criptografia.Location = new System.Drawing.Point(147, 80);
            this.cb_criptografia.Name = "cb_criptografia";
            this.cb_criptografia.Size = new System.Drawing.Size(121, 23);
            this.cb_criptografia.TabIndex = 7;
            this.cb_criptografia.Tag = "infoObrigatoria";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "* Nome de usuário:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nomeUsuario
            // 
            this.txt_nomeUsuario.Location = new System.Drawing.Point(147, 109);
            this.txt_nomeUsuario.Name = "txt_nomeUsuario";
            this.txt_nomeUsuario.Size = new System.Drawing.Size(121, 23);
            this.txt_nomeUsuario.TabIndex = 8;
            this.txt_nomeUsuario.Tag = "infoObrigatoria";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "* Senha:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(603, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMTP Testing Tool";
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private GroupBox groupBox3;
        private Button btn_testar;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox txt_servidorEntrada;
        private ComboBox cb_requerSSL;
        private Label label8;
        private Label label9;
        private TextBox txt_portaEntrada;
        private GroupBox groupBox1;
        private TextBox txt_servidorSaida;
        private Label label2;
        private Label label3;
        private TextBox txt_portaSMTP;
        private Label label4;
        private ComboBox cb_criptografia;
        private Label label6;
        private TextBox txt_nomeUsuario;
        private Label label5;
        private RichTextBox rctxt_log;
        private TextBox txt_senhaUsuario;
        private GroupBox groupBox4;
        private Label label10;
        private TextBox txt_destinatario;
        private Button btn_limparLog;
        private Label label;
        private RichTextBox rctxt_mensagem;
        private Label label11;
        private TextBox txt_assunto;
    }
}