﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Entidades
{
    public class Usuario
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public string CPFCNPJ { get; set; }
        public string Cidade { get; set; }
        public string NumCNH { get; set; }
        public string CategoriaCNH { get; set; }
        public string CodSegurancaCNH { get; set; }
        public DateTime DataEmissaoCNH { get; set; }
        public string EstadoEmissorCNH { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public decimal SeqTipoCaminhao { get; set; }
        public Caminhao SeqCaminhao { get; set; }
    }
}
