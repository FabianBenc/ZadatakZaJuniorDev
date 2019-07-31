using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Imenik.Models
{
    public class ImenikContext : DbContext
    {
        public ImenikContext (DbContextOptions<ImenikContext> options) : base(options){

        }

        public DbSet<Imenik.Models.Kontakti> kontakti { get; set; }
        public DbSet<Imenik.Models.Telefon> telefon { get; set; }
    }
}