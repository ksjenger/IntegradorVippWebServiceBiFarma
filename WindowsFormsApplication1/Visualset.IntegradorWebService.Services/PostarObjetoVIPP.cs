using IntegradorWebService.WSVIPP;
using System;
using System.Collections.Generic;
using System.Windows;


namespace IntegradorWebService.VIPP
{
    class PostarObjetoVIPP
    {
        #region Recebe a lista, Faz a chamada no Web Service. O metodo faz outra chamada para guardar o retorno em 2 listas

        public List<string> lRetorno = new List<string>();

        public static void Postagem(List<Postagem> lVipp, Form1 frm, PerfilVipp oPerfil)
        {
            string oRetorno = null;
            int cont = 0;
            try
            {
                frm.progressBar.Maximum = lVipp.Count + 1;
                frm.progressBar.Visible = true;
                frm.progressBar.Value = 1;
                frm.labelProgresso.Text = "Transmitindo para o VIPP";
            }
            catch (NullReferenceException)
            {

            }

            foreach (Postagem o in lVipp)
            {
                try
                {
                    cont++;
                    frm.progressBar.Value++;
                }
                catch (NullReferenceException)
                {

                }
                try
                {
                    Postagem oPostagem = new Postagem
                    {
                        Destinatario = o.Destinatario,
                        ContratoEct = o.ContratoEct,
                        NotasFiscais = o.NotasFiscais,
                        PerfilVipp = new PerfilVipp()
                        {
                            Usuario = oPerfil.Usuario,
                            IdPerfil = oPerfil.IdPerfil,
                            Token = oPerfil.Token
                        },
                        Servico = o.Servico,
                        Volumes = o.Volumes
                    };

                    using (PostagemVipp oSigep = new PostagemVipp())
                    {
                        try
                        {
                            oRetorno = oSigep.PostarObjeto(oPostagem).InnerXml;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Erro: " + e.Message + " verifique a conexao com a Internet");
                        }
                        TrataRetorno.RetornoPostagem(oRetorno);
                    }
                }
                catch (NullReferenceException)
                {

                }

            }
        }
        #endregion

    }
}