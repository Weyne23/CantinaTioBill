using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaTioBill
{
    class Globais
    {
        public static string versao = "1.0";
        public static int nivel = 0; // basico = 1, adm = 2, master = 3
        public static bool logado = false;
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "db_cantina.db";
        public static string caminhoBanco = caminho + "/banco";
    }
}
