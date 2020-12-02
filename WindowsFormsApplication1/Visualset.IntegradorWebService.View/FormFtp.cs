using IntegradorWebService.Visualset.IntegradorWebService.Entities;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace IntegradorWebService.Visualset.IntegradorWebService.View
{
    public partial class FormFtp : Form
    {
        public FormFtp(Rootobject lPerfil)
        {
            IniFile oIniFile = new IniFile("Config");
            InitializeComponent();
            this.Text = "Configurações";
            txtDiretorioEntrada.Text = oIniFile.IniReadString("Entrada");
            txtDiretorioSaida.Text = oIniFile.IniReadString("SaveFile"); ;
            checkServico.Checked = Properties.Settings.Default.ServicoAtivo;
            if (checkServico.Checked)
            {
                checkServico.BackColor = Color.Green;
            }
            else
            {
                checkServico.BackColor = Color.Red;
            }
            try
            {                
                comboPerfil.Items.Add(oIniFile.IniReadString("IdPerfil"));
            }
            catch (ArgumentNullException)
            {
                comboPerfil.Items.Add("Selecione o Perfil");

            }
            comboPerfil.SelectedIndex = 0;
            for (int i = 0; i < lPerfil.Data.Length; i++)
            {
                comboPerfil.Items.Add(lPerfil.Data[i].IdPerfil + " - " + lPerfil.Data[i].NomePerfil);
            }

        }

        private void btnSelecione_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                IniFile oIniFile = new IniFile("Config");
                folderBrowserDialog.SelectedPath = oIniFile.IniReadString("Entrada"); 
                folderBrowserDialog.Description = "Selecione o diretorio.";
                folderBrowserDialog.ShowDialog();
                txtDiretorioEntrada.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (txtDiretorioEntrada.Text.Length > 2 && txtDiretorioSaida.Text.Length > 2)
            {
                Properties.Settings.Default.ServicoAtivo = checkServico.Checked;
                string[] split = comboPerfil.SelectedItem.ToString().Split('-');

                try
                {
                    IniFile oIniFile = new IniFile("Config");
                    oIniFile.IniWriteString("Entrada", txtDiretorioEntrada.Text);
                    oIniFile.IniWriteString("SaveFile", txtDiretorioSaida.Text);
                    oIniFile.IniWriteString("IdPerfil", split[0]);
                    MessageBox.Show("As configurações foram salvas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (checkServico.Checked)
                    {
                        Process myProcess = new Process();

                        myProcess.StartInfo.FileName = "cmd.exe";
                        myProcess.StartInfo.UseShellExecute = false;
                        myProcess.StartInfo.Verb = "runas";
                        myProcess.StartInfo.Arguments = "/c \"net start Service1\"";

                        myProcess.Start();
                        
                        myProcess.WaitForExit();                       
                                                       

                    }
                    else
                    {
                        Process myProcess = new Process();

                        myProcess.StartInfo.FileName = "cmd.exe";
                        myProcess.StartInfo.UseShellExecute = false;
                        myProcess.StartInfo.Verb = "runas";
                        myProcess.StartInfo.Arguments = "/c \"net stop Service1\"";

                        myProcess.Start();
                        myProcess.WaitForExit();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Preencha todos os Campos", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                IniFile oIniFile = new IniFile("Config");
                folderBrowserDialog.SelectedPath = oIniFile.IniReadString("SaveFile");
                folderBrowserDialog.Description = "Selecione o diretorio.";
                folderBrowserDialog.ShowDialog();
                txtDiretorioSaida.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void checkServico_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
