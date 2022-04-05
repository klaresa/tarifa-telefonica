using System;

namespace TarifaTelefonica.Domain
{
    public class Usuario
    {
        public string Nome { get; set; }
        public Agenda Agenda { get; set; }
        public Fatura Fatura { get; set; }
    }
}
