using CrudAgendaAngular.Data;
using CrudAgendaAngular.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudAgendaAngular.Business
{
    public class ContatoBusiness
    {
        internal ICollection<Contato> CarregarTodos()
        {
            var data = new ContatoData();
            return data.CarregarTodos();
        }
    }
}