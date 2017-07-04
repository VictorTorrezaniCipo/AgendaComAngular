using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudAgendaAngular.Entities
{
    public class Parentesco
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Contato> Contatos { get; set; }
    }
}