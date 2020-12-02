using IntegradorWebService.ExcelServices;
using IntegradorWebService.Services;
using IntegradorWebService.VIPP;
using IntegradorWebService.WSVIPP;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;


namespace IntegradorWebService.Visualset.IntegradorWebService
{
    public class PostagemAutomatica
    {
        public PostagemAutomatica()
        {
            List<Postagem> lVipp = new List<Postagem>();
            lVipp = CarregaArquivos();
            
        }

        public List<Postagem> CarregaArquivos()
        {
            IniFile oIniFile = new IniFile("Config");            
            List<Postagem> lVipp = new List<Postagem>();
            string path = oIniFile.IniReadString("Entrada");


            if (!Directory.Exists(string.Concat(path, @"\\TEMP")))
            {
                Directory.CreateDirectory(string.Concat(path, @"\\TEMP"));
            }
            string[] arquivos = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);

            foreach (string arq in arquivos)
            {
                FileInfo fileInfo = new FileInfo(arq);
                string fileName = fileInfo.Name;
                if (!File.Exists(string.Concat(path, @"\\TEMP\\", fileName)))
                {
                    Postar(ProcessaPlanilha.ListaDePostagem(arq, null, "txt"), fileName);
                    GravaRetorno.GravaRetornoTxt(fileName);
                    File.Move(arq, string.Concat(path, @"\\TEMP\\", fileName));
                }
                else
                {
                    if (!Directory.Exists(@"C:\Visualset.IntegradorWebService"))
                    {
                        Directory.CreateDirectory(@"C:\Visualset.IntegradorWebService");
                    }
                    using (StreamWriter vWriter = new StreamWriter(@"C:\Visualset.IntegradorWebService\LogServico.txt", true))
                    {
                        vWriter.WriteLine(string.Concat(DateTime.Now.ToString(), " | | O arquivo ", fileName, " já foi importado"));
                        vWriter.Flush();
                        vWriter.Close();
                    }                    
                }
            }
            return lVipp;
        }

        public void Postar(List<Postagem> lVipp, string fileName)
        {
            IniFile oIniFile = new IniFile("Config");
            PerfilVipp oPerfil = new PerfilVipp()
            {
                IdPerfil = oIniFile.IniReadString("IdPerfil"),
                Usuario = oIniFile.IniReadString("Usuario"),
                Token = oIniFile.IniReadString("Senha")
            };

            PostarObjetoVIPP.Postagem(lVipp, null, oPerfil);

            if (!Directory.Exists(@"C:\Visualset.IntegradorWebService"))
            {
                Directory.CreateDirectory(@"C:\Visualset.IntegradorWebService");
            }
            using(StreamWriter vWriter = new StreamWriter(@"C:\Visualset.IntegradorWebService\LogServico.txt", true)){
                vWriter.Flush();
                vWriter.WriteLine(string.Concat(DateTime.Now.ToString(), " | | Realizado a Importação do arquivo ", fileName, " com ", TrataRetorno.lRetornoInvalida.Count, " erros "));
                vWriter.Close();
            }


        }

    }
}
