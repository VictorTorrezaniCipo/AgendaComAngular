using CrudAgendaAngular.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CrudAgendaAngular.Data
{
    public class ContatoData
    {
        internal ICollection<Contato> CarregarTodos()
        {
            using (var ctx = new BancoContext())
            {
                return ctx.Contato.Include(x => x.GrauDeParentesco).ToList();
            }
        }
    }
}