using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaTioBill.Moldels
{
    class CantinaContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source = DESKTOP-9FAFID2\\SQLEXPRESS; Initial Catalog = db_cantina; Integrated Security = True");
        }
    }
}
