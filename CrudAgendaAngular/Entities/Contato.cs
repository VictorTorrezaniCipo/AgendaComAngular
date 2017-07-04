using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudAgendaAngular.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Celular { get; set; }
        public int? IdGrauDeParentesco { get; set; }

        public Parentesco GrauDeParentesco { get; set; }
    }
}