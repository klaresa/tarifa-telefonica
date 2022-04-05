using System;
using TarifaTelefonica.Domain;

namespace TarifaTelefonica.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Controlador controlador = new Controlador(new Usuario());
            controlador.Executar();
        }
    }
}
