using System;
using System.Configuration;
using System.Windows.Forms;
using IntegradorWebService.Rest;
using IntegradorWebService.Visualset.IntegradorWebService.Entities;

namespace IntegradorWebService
{
    public partial class Login : Form
    {

        internal static PerfilImportacao Operfil { get; set; }

        public Login()
        {
            InitializeComponent();
            this.Text = "Login - Versão: " + Application.ProductVersion;
            IniFile oIniFile = new IniFile("Config");
            if (Properties.Settings.Default.LembrarSenha)
            {
                txtUsr.Text = oIniFile.IniReadString("Usuario");
                txtPwd.Text = oIniFile.IniReadString("Senha");
                checkLembrar.Checked = true;
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Operfil = new PerfilImportacao()
            {
                Usuario = txtUsr.Text,
                Token = txtPwd.Text
            };

            if (txtUsr.Text.Length < 6)
            {
                MessageBox.Show("O usuário deve conter no minimo 6 caracteres", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPwd.Text.Length < 6)
            {
                MessageBox.Show("A senha deve conter no minimo 6 caracteres", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Logar.LogarVipp(txtUsr.Text, txtPwd.Text))
            {
                Hide();
                IniFile oIniFile = new IniFile("Config");
                oIniFile.IniWriteString("Usuario", txtUsr.Text);
                oIniFile.IniWriteString("Senha", txtPwd.Text);               
                Properties.Settings.Default.LembrarSenha = checkLembrar.Checked;
                Properties.Settings.Default.Save();
                new Form1().ShowDialog();
                //Application.Exit();
            }
        }

        private void linkLbnEsqueci_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vipp.visualset.com.br/vipp/login/EsqueceuUsuarioSenha.php");
        }
    }
}
