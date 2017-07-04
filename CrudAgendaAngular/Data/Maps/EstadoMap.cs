using CrudAgendaAngular.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrudAgendaAngular.Data.Maps
{
    public class EstadoMap : EntityTypeConfiguration<Estado>
    {
        public EstadoMap()
        {
            ToTable("State");
            Property(x => x.Nome).HasColumnName("Name");
            Property(x => x.Sigla).HasColumnName("Acronym");
        }
    }
}