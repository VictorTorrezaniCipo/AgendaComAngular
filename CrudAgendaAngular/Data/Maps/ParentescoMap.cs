using CrudAgendaAngular.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrudAgendaAngular.Data.Maps
{
    public class ParentescoMap : EntityTypeConfiguration<Parentesco>
    {
        public ParentescoMap()
        {
            ToTable("Parentesco");
        }
    }
}