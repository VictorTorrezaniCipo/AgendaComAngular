using CrudAgendaAngular.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudAgendaAngular.Data
{
    public class BancoContext : DbContext
    {
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Parentesco> GrauDeParentesco { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }

        public BancoContext() : base("Banco")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(BancoContext).Assembly);
        }
    }
}