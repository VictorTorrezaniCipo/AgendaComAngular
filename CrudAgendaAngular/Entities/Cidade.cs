using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudAgendaAngular.Entities
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdEstado { get; set; }

        public Estado Estado { get; set; }
    }
}