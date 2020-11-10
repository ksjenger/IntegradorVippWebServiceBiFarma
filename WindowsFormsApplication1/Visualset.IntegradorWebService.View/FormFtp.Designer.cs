namespace IntegradorWebService.Visualset.IntegradorWebService.View
{
    partial class FormFtp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxServidorFtp = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lbnServidor = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.LbnSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.LbnUsuario = new System.Windows.Forms.Label();
            this.groupBoxServidorFtp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxServidorFtp
            // 
            this.groupBoxServidorFtp.Controls.Add(this.btnCancelar);
            this.groupBoxServidorFtp.Controls.Add(this.btnSalvar);
            this.groupBoxServidorFtp.Controls.Add(this.txtServidor);
            this.groupBoxServidorFtp.Controls.Add(this.lbnServidor);
            this.groupBoxServidorFtp.Controls.Add(this.txtSenha);
            this.groupBoxServidorFtp.Controls.Add(this.LbnSenha);
            this.groupBoxServidorFtp.Controls.Add(this.txtUsuario);
            this.groupBoxServidorFtp.Controls.Add(this.LbnUsuario);
            this.groupBoxServidorFtp.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBoxServidorFtp.ForeColor = System.Drawing.Color.Navy;
            this.groupBoxServidorFtp.Location = new System.Drawing.Point(13, 13);
            this.groupBoxServidorFtp.Name = "groupBoxServidorFtp";
            this.groupBoxServidorFtp.Size = new System.Drawing.Size(738, 223);
            this.groupBoxServidorFtp.TabIndex = 0;
            this.groupBoxServidorFtp.TabStop = false;
            this.groupBoxServidorFtp.Text = "Servidor Ftp";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(441, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 26);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(243, 175);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 26);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(92, 113);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(598, 27);
            this.txtServidor.TabIndex = 5;
            this.txtServidor.Leave += new System.EventHandler(this.txtServidor_Leave);
            // 
            // lbnServidor
            // 
            this.lbnServidor.AutoSize = true;
            this.lbnServidor.Location = new System.Drawing.Point(23, 114);
            this.lbnServidor.Name = "lbnServidor";
            this.lbnServidor.Size = new System.Drawing.Size(67, 20);
            this.lbnServidor.TabIndex = 4;
            this.lbnServidor.Text = "Servidor:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(533, 47);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(157, 27);
            this.txtSenha.TabIndex = 3;
            // 
            // LbnSenha
            // 
            this.LbnSenha.AutoSize = true;
            this.LbnSenha.Location = new System.Drawing.Point(464, 48);
            this.LbnSenha.Name = "LbnSenha";
            this.LbnSenha.Size = new System.Drawing.Size(52, 20);
            this.LbnSenha.TabIndex = 2;
            this.LbnSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(92, 46);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(157, 27);
            this.txtUsuario.TabIndex = 1;
            // 
            // LbnUsuario
            // 
            this.LbnUsuario.AutoSize = true;
            this.LbnUsuario.Location = new System.Drawing.Point(23, 47);
            this.LbnUsuario.Name = "LbnUsuario";
            this.LbnUsuario.Size = new System.Drawing.Size(62, 20);
            this.LbnUsuario.TabIndex = 0;
            this.LbnUsuario.Text = "Usuario:";
            // 
            // FormFtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 246);
            this.Controls.Add(this.groupBoxServidorFtp);
            this.Name = "FormFtp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFtp";
            this.groupBoxServidorFtp.ResumeLayout(false);
            this.groupBoxServidorFtp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxServidorFtp;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label LbnSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label LbnUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lbnServidor;
    }
}