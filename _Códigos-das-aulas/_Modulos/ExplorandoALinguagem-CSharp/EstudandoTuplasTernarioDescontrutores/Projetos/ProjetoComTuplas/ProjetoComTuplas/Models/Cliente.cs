using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoComTuplas.Models
{
    public class Cliente : Restaurante
    {
        protected string? name = "";
        private readonly string[] _cardapio = [];
        private readonly List<string> _pedido = [];
        
        private void Pedido()
        {
            string[] cardapioDoRestaurante = GetCardapio();
            string? opcao = "";
            string? maisUmPedido = "";
            int opcaoNumbe = 0;
            int pedidoNumber = 0;
            int quantidade = 0;
            bool _continuar = true;

            while (_continuar)
            {
                Console.Clear();
                if (_pedido.Count > 0)
                {
                    Console.WriteLine("--Pedidos..: ");
                    foreach (string item in _pedido)
                    {
                        Console.WriteLine($"\t- {item}");
                    }
                    Console.WriteLine("-------------------------");
                }

                quantidade = 0;
                Console.WriteLine("--Cardapio..: ");
                foreach(string item in cardapioDoRestaurante)
                {
                    quantidade++;
                    Console.WriteLine($"\t{quantidade} - {item}");
                }

                Console.Write("Qual item você deseja? ");
                opcao = Console.ReadLine();
                while (!int.TryParse(opcao, out _))
                {
                    Console.WriteLine("Opção invalida, favor escolha uma opção presente no cardapio.");   
                    Console.Write("-Pedido..: ");
                    opcao = Console.ReadLine();
                }
        
                opcaoNumbe = Convert.ToInt32(opcao);
                if (opcaoNumbe > 0 && opcaoNumbe < cardapioDoRestaurante.Length)
                {
                    //pedidoCliente[pedidoNumber] = cardapioDoRestaurante[opcaoNumbe -1];
                    //pedidoNumber++;
                    Console.WriteLine($"Item selecionado..: {cardapioDoRestaurante[opcaoNumbe -1]}");
                    _pedido.Add(cardapioDoRestaurante[opcaoNumbe -1]);
                    pedidoNumber++;

                    Console.Write("--Deseja adicionar mais um item? ");
                    maisUmPedido = Console.ReadLine();

                    _continuar = maisUmPedido == "s" || maisUmPedido == "S";
                } else
                {
                    Console.WriteLine("Opção não encontrada, favor escolha uma das opções presentes no cardapio.");
                }
            }

            Console.Write("Qual será o nome presente na comanda? ");
            name = Console.ReadLine();
        }

        public List<string> Comanda()
        {
            Pedido();
            return _pedido;
        }
        
        //public void Conta(){}
    }
}
