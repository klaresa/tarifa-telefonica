using System;
using System.Collections.Generic;
using System.Text;

namespace TarifaTelefonica.Domain
{
    public class Ligacao
    {
        public Contato Contato { get; set; }
        public int Pulso { get; set; }
        private TimeSpan _duracao { get; set; }

    public TimeSpan Ligar(string numero)
        {
            var calling = true;
            var inicio = DateTime.Now;

            while (calling != false)
            {
                Console.WriteLine("In a call... Aperte qualquer tecla para finalizar.");
                Console.ReadLine();
                calling = false;
            };

            var fim = DateTime.Now;
            _duracao = fim - inicio;


            return _duracao;
        }

        public int ContabilizarPulsos()
        {
            var mins = _duracao.Minutes / 4;
            return Pulso + mins;
        }
    }
}
