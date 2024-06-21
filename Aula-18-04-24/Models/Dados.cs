using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Aula_18_04_24.Models
{
    public partial class Dados : DbContext
    {
        public Dados()
            : base("Dados")
        {
        }

        public virtual DbSet<Pessoas> Pessoas { get; set; }

        public virtual DbSet<Professor> Professor { get; set; }
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoas>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
