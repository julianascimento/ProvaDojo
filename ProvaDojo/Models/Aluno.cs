using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaDojo.Models
{
    public class Aluno
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public Faixa Faixa { get; set; }
        public TipoDeAssociacao TipoDeAssociacao { get; set; }
    }
}