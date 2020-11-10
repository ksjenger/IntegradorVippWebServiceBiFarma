using IntegradorWebService.Visualset.IntegradorWebService.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegradorWebService.Visualset.IntegradorWebService.View
{
    public partial class FormFtp : Form
    {
        public FormFtp()
        {
            InitializeComponent();
            this.Text = "Configuracao | FTP";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length > 2 && txtSenha.Text.Length > 2 && txtServidor.Text.Length > 2)
            {
                ConfiguracaoFtp oConfiguracao = new ConfiguracaoFtp()
                {
                    Usuario = txtUsuario.Text,
                    Senha = txtSenha.Text,
                    Servidor = txtSenha.Text
                };
                Properties.Settings.Default.UsuarioFtp = oConfiguracao.Usuario;
                Properties.Settings.Default.SenhaFtp = oConfiguracao.Senha;
                Properties.Settings.Default.ServidorFtp = oConfiguracao.Servidor;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Informe todos os Campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtServidor_Leave(object sender, EventArgs e)
        {
            txtServidor.Text = txtServidor.Text.ToUpper().Replace("FTP://", "");
            txtServidor.Text = string.Concat("ftp://", txtServidor.Text, "/");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
