using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorWebService.Visualset.IntegradorWebService.Entities
{
    public class ConfiguracaoFtp
    {

        #region Atributos
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Servidor { get; set; }
        #endregion

        #region Construtores
        public ConfiguracaoFtp()
        {
            Usuario = string.Empty;
            Senha = string.Empty;
            Servidor = string.Empty;
        }
        #endregion


    }
}
