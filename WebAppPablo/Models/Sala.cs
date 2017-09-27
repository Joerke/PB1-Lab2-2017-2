using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPablo.Models
{
    public class Sala
    {
        public int SalaId { get; set; }
        public int Numero { get; set; }
        public int Capacidade { get; set; }
        public string Descricao { get; set; }
        public List<Sessao> Sessaoes { get; set; }


    }
}