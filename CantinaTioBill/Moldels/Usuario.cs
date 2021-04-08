using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaTioBill.Moldels
{
    class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }
        public int Nivel { get; set; }
        public string Status { get; set; }
    }
}
