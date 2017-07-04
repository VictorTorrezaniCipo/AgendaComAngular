using CrudAgendaAngular.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrudAgendaAngular.Data.Maps
{
    public class ContatoMap : EntityTypeConfiguration<Contato>
    {
        public ContatoMap()
        {
            ToTable("Pessoas");

            this.HasRequired(pa => pa.GrauDeParentesco)
                .WithMany(x => x.Contatos)
                .HasForeignKey(p => p.IdGrauDeParentesco);
        }
    }
}