using System;
using System.Collections.Generic;
using System.Text;

namespace TarifaTelefonica.Domain
{
    public class Agenda
    {
        private List<Contato> _contatos { get; set; }

        public void AdicionarContato(Contato contato)
        {
            _contatos.Add(contato);
        }

        public List<Contato> ListarContatos()
        {
            return _contatos;
        }
    }
}
