using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TarifaTelefonica.Domain
{
    public class Controlador
    {
        public Usuario Usuario { get; set; }

        public Controlador(Usuario usuario) { }

        // usuario > agenda + fatura
        // agenda > contatos
        // fatura > ligacoes
        // ligacao > contato
        public void Executar()
        {
            const string FIM = "0";


            Console.WriteLine("Digite seu nome...");
            Usuario usuario = new Usuario();
            usuario.Nome = Console.ReadLine();

            MostrarOpcoes();
            var incomming = Console.ReadLine();

            while (incomming != FIM)
            {

                switch (incomming)
                {
                    case "1":
                        Console.WriteLine("Caso 1");
                        Contato cont = new Contato();
                        cont.Nome = "ANA";
                        cont.Telefone = "123";

                        Ligacao ligacao = new Ligacao();
                        var duracao = ligacao.Ligar(cont.Telefone);

                        Fatura fatura = new Fatura();
                        usuario.Fatura = fatura;
                        usuario.Fatura.AdicionarLigacao(ligacao);
                        break;
                    case "2":
                        Console.WriteLine("Fatura");
                        Console.WriteLine("Pulso " + usuario.Fatura.CalcularFatura());
                        break;
                }

                MostrarOpcoes();
                incomming = Console.ReadLine();
            }
        }

        public void MostrarOpcoes()
        {
            Console.WriteLine("1 - Ligar");
            Console.WriteLine("2 - Fatura");
            Console.WriteLine("0 - Terminar");
        }
    }
}
