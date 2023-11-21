using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Entidades
{
    public class Empresa
    {
        public long Codigo { get; set; }
        public string? Nome { get; set; }
        public string? CNPJ { get; set; }
        public string? Email { get; set; }
        public string? Contato { get; set; }
    }
}
