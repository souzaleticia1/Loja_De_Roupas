//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Configuration;

//namespace Loja_De_Roupas
//{
//    internal class Tema
//    {

//public static class ConfiguracoesTema
//    {
//        private const string ChaveTema = "TemaEscuro";

//        public static bool TemaEscuro
//        {
//            get
//            {
//                string valor = ConfigurationManager.AppSettings[ChaveTema];
//                return string.IsNullOrEmpty(valor) ? false : Convert.ToBoolean(valor);
//            }
//            set
//            {
//                ConfigurationManager.AppSettings[ChaveTema] = value.ToString();
//            }
//        }
//    }

//}
//}

using System;
using System.IO;

public static class Tema
{
    private static readonly string caminhoArquivo = "configuracoesTema.txt";

    public static bool TemaEscuro
    {
        get
        {
            return File.Exists(caminhoArquivo) ? Convert.ToBoolean(File.ReadAllText(caminhoArquivo)) : false;
        }
        set
        {
            File.WriteAllText(caminhoArquivo, value.ToString());
        }
    }
}

