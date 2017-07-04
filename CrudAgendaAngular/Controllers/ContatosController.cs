using CrudAgendaAngular.Business;
using CrudAgendaAngular.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrudAgendaAngular.Controllers
{
    public class ContatosController : ApiController
    {
        public ICollection<Contato> Get()
        {
            var business = new ContatoBusiness();
            return business.CarregarTodos();
        }
    }
}
