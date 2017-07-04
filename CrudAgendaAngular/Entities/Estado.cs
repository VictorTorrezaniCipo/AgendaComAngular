﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudAgendaAngular.Entities
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public ICollection<Cidade> Cidades { get; set; }
    }
}