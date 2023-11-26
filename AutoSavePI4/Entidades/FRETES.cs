using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSavePI4.Entidades
{
    public class Fretes
    {
        [Key]
        public long Codigo { get; set; }
        public string? TipoCarga { get; set; }
        public string? Pesocarga { get; set; }
        public string? LocalColeta { get; set; }
        public string? LocalEntrega { get; set; }
        public decimal? ValorPagamento { get; set; }
        public long? SeqEmpresa { get; set; }
        public long? SeqUsuario { get; set; }
        public Empresa? Empresa { get; set; }
        public Usuario? Usuario { get; set; }



    }
}
