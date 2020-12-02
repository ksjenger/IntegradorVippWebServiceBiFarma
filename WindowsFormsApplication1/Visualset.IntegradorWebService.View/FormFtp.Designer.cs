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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFtp));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboPerfil = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtDiretorioSaida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkServico = new System.Windows.Forms.CheckBox();
            this.btnSelecione = new System.Windows.Forms.Button();
            this.txtDiretorioEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 267);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboPerfil);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.txtDiretorioSaida);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkServico);
            this.groupBox2.Controls.Add(this.btnSelecione);
            this.groupBox2.Controls.Add(this.txtDiretorioEntrada);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(6, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 189);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pasta Local";
            // 
            // comboPerfil
            // 
            this.comboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPerfil.FormattingEnabled = true;
            this.comboPerfil.Location = new System.Drawing.Point(468, 131);
            this.comboPerfil.Name = "comboPerfil";
            this.comboPerfil.Size = new System.Drawing.Size(222, 28);
            this.comboPerfil.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(650, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 27);
            this.button3.TabIndex = 11;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDiretorioSaida
            // 
            this.txtDiretorioSaida.Location = new System.Drawing.Point(92, 85);
            this.txtDiretorioSaida.Name = "txtDiretorioSaida";
            this.txtDiretorioSaida.Size = new System.Drawing.Size(556, 27);
            this.txtDiretorioSaida.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Saída:";
            this.label2.UseMnemonic = false;
            // 
            // checkServico
            // 
            this.checkServico.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkServico.AutoSize = true;
            this.checkServico.Location = new System.Drawing.Point(27, 133);
            this.checkServico.Name = "checkServico";
            this.checkServico.Size = new System.Drawing.Size(110, 30);
            this.checkServico.TabIndex = 7;
            this.checkServico.Text = "Ativar Serviço";
            this.checkServico.UseVisualStyleBackColor = true;
            this.checkServico.CheckedChanged += new System.EventHandler(this.checkServico_CheckedChanged);
            // 
            // btnSelecione
            // 
            this.btnSelecione.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSelecione.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecione.Image")));
            this.btnSelecione.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelecione.Location = new System.Drawing.Point(650, 39);
            this.btnSelecione.Name = "btnSelecione";
            this.btnSelecione.Size = new System.Drawing.Size(40, 27);
            this.btnSelecione.TabIndex = 6;
            this.btnSelecione.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelecione.Click += new System.EventHandler(this.btnSelecione_Click);
            // 
            // txtDiretorioEntrada
            // 
            this.txtDiretorioEntrada.Location = new System.Drawing.Point(92, 39);
            this.txtDiretorioEntrada.Name = "txtDiretorioEntrada";
            this.txtDiretorioEntrada.Size = new System.Drawing.Size(556, 27);
            this.txtDiretorioEntrada.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entrada:";
            this.label1.UseMnemonic = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(463, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 26);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(588, 230);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 26);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // FormFtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 285);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormFtp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFtp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDiretorioEntrada;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.CheckBox checkServico;
        private System.Windows.Forms.Button btnSelecione;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtDiretorioSaida;
        private System.Windows.Forms.Label label2;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.ComboBox comboPerfil;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}