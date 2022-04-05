using System;
using System.Collections.Generic;
using System.Text;

namespace TarifaTelefonica.Domain
{
    public class Fatura
    {
        private static List<Ligacao> _ligacoes = new List<Ligacao>();
        private int _pulsos = 0;
        private const double CUSTO = 0.08;

        public void AdicionarLigacao(Ligacao ligacao)
        {
            _ligacoes.Add(ligacao);
        }

        public List<Ligacao> ListarLigacoes()
        {
            return _ligacoes;
        }

        public double CalcularFatura()
        {
            _ligacoes.ForEach(item => _pulsos++);
            return _pulsos * 0.08;
        }
    }
}
