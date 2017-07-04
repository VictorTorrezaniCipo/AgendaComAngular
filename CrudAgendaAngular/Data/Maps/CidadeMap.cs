using CrudAgendaAngular.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrudAgendaAngular.Data.Maps
{
    public class CidadeMap : EntityTypeConfiguration<Cidade>
    {
        public CidadeMap()
        {
            ToTable("City");
            Property(x => x.Nome).HasColumnName("Name");
            Property(x => x.IdEstado).HasColumnName("IdState");

            this.HasRequired(e => e.Estado)
                .WithMany(c => c.Cidades)
                .HasForeignKey(e => e.IdEstado);
        }
    }
}