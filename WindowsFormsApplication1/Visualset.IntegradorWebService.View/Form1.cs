using IntegradorWebService.ExcelServices;
using IntegradorWebService.Rest;
using IntegradorWebService.Services;
using IntegradorWebService.VIPP;
using IntegradorWebService.Visualset.IntegradorWebService.Entities;
using IntegradorWebService.Visualset.IntegradorWebService.View;
using IntegradorWebService.WSVIPP;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace IntegradorWebService
{
    public partial class Form1 : Form
    {
        IniFile oIniFile = new IniFile("Config");

        List<Postagem> lVipp = new List<Postagem>();
        public Rootobject lPerfil = new Rootobject();
        public PerfilVipp oPerfil = new PerfilVipp();

        public static string path;
        public static string nomeArquivo;
        public static string caminhoArquivo;
        public static string tipoArquivo;

        public Form1()
        {
            InitializeComponent();
            IniFile oIniFile = new IniFile("Config");
            oPerfil.Usuario = oIniFile.IniReadString("Usuario");
            oPerfil.Token = oIniFile.IniReadString("Senha");
            oPerfil.IdPerfil = oIniFile.IniReadString("IdPerfil");
            //BtnFtp.Visible = false;
            this.Text = "Importador Visual Personalizado - Versão: " + Application.ProductVersion + "  -  " + oPerfil.Usuario;
            btnEnviar.Enabled = false;
            lPerfil = RestPerfilImportacao.ProcessaListaPerfil(oPerfil.Usuario, oPerfil.Token);
            comboPerfil.Items.Add("Selecione o Perfil");
            comboPerfil.SelectedIndex = 0;
            for (int i = 0; i < lPerfil.Data.Length; i++)
            {
                comboPerfil.Items.Add(lPerfil.Data[i].IdPerfil + " - " + lPerfil.Data[i].NomePerfil);
            }
            progressBar.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            int id = comboPerfil.SelectedIndex;

            if (id == 0)
            {
                MessageBox.Show("Selecione o perfil de importação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                Login.Operfil.IdPerfil = lPerfil.Data[id - 1].IdPerfil;

                #region Chama o metodo para Postar Objeto
                labelProgresso.Text = "Transmitindo para o VIPP";
                PostarObjetoVIPP.Postagem(lVipp, this, oPerfil);

                #endregion

                labelProgresso.Text = "Salvando o arquivo processado...";

                switch (tipoArquivo)
                {
                    case "csv":
                        GravaRetorno.GravaRetornoTxt();
                        break;
                    case "CENGAGE - EXCEL":
                        GravaRetorno.GravaRetornoExcel();
                        break;
                    case "txt":
                        GravaRetorno.GravaRetornoTxt();
                        break;

                }

                if (TrataRetorno.lRetornoValida.Count > 0)
                {
                    MessageBox.Show(string.Concat("Foram importados ", TrataRetorno.lRetornoValida.Count, " objetos com sucesso!"), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (TrataRetorno.lRetornoInvalida.Count > 0)
                {
                    MessageBox.Show(string.Concat(TrataRetorno.lRetornoInvalida.Count, " Apresentaram erro, confira o log de importação."), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                MessageBox.Show("Importação finalizada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                path = null;
                labelPath.Text = "";
                labelProgresso.Text = "";
                btnEnviar.Enabled = false;
                progressBar.Value = 0;
                progressBar.Visible = false;
            }
        }

        private void ComboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (path == null)
            {
                btnSelecione.Focus();
            }
            else
            {
                btnEnviar.Focus();
            }
        }

        #region Abre o Arquivo
        private void Button1_Click_1(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                openFileDialog.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lVipp = null;
                    tipoArquivo = "txt";
                    path = openFileDialog.FileName;
                    nomeArquivo = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                    caminhoArquivo = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                    labelPath.Text = path;
                    labelProgresso.Text = "Importando o Arquivo";
                    #region Processa o Arquivo
                    lVipp = ProcessaPlanilha.ListaDePostagem(path, this, tipoArquivo);
                    #endregion

                    if (lVipp == null)
                    {
                        labelProgresso.Text = "";
                        labelPath.Text = "";
                        path = null;
                    }
                    else
                    {
                        labelProgresso.Text = "Arquivo importado!";
                        btnEnviar.Enabled = true;
                        comboPerfil.Focus();
                    }
                }
            }
        }
        #endregion

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.visualset.com.br");
            System.Diagnostics.Process.Start("http://vipp.visualset.com.br");
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                IniFile oIniFile = new IniFile("Config");
                folderBrowserDialog.SelectedPath = oIniFile.IniReadString("SaveFile");
                folderBrowserDialog.Description = "Selecione onde salvar o arquivo processado";
                folderBrowserDialog.ShowDialog();
                oIniFile.IniWriteString("SaveFile", folderBrowserDialog.SelectedPath);
            }
        }

        private void BtnFtp_Click(object sender, EventArgs e)
        {
            FormFtp oForm = new FormFtp(lPerfil);
            oForm.Show();
        }


        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
