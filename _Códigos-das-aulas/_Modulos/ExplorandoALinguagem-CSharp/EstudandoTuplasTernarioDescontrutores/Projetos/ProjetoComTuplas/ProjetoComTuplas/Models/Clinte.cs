using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoComTuplas.Models
{
    public class Cliente : Restaurante
    {
        //ver o cardapio
        //escolher o pedido 
        //emitir nota
        private string? _name = "";
        private List<string?> _pedidos = [];

        private List<string?> SetPedidos()
        {
            _pedidos.Clear();
            List<string?> cardapio = GetCardapio();
            string? addMaisUmItem = "";
            string? itemEscolhido = "";
            int itemSelecionado = 0;
            int itens = 0;
            
            bool _continue = true;
            while (_continue)
            {
                Console.Clear();
                itens = 0;
                itemSelecionado = 0;
                Console.WriteLine("--Cardapio..: ");
                foreach (string? item in cardapio)
                {
                    itens++;
                    Console.WriteLine($"\t{itens} - {item}");
                }
                Console.WriteLine("----------------------------------");

                Console.Write("-Qual item você deseja? ");
                itemEscolhido = Console.ReadLine();
                do
                {
                    while (!int.TryParse(itemEscolhido, out _))
                    {
                        Console.WriteLine("\n[Erro]: Valor invalido, favor informe um valor valido.");
                        Console.Write("--> ");
                        itemEscolhido = Console.ReadLine();
                    }

                    if (int.TryParse(itemEscolhido, out _))
                    {
                        if (Convert.ToInt32(itemEscolhido) < 1 || Convert.ToInt32(itemEscolhido) > cardapio.Count)
                        {
                            Console.WriteLine("Item não encontrado no cardapio, favor informe um item presente no cardapio.");
                            itemEscolhido = "NaN";
                        } else
                        {
                            itemSelecionado = Convert.ToInt32(itemEscolhido);
                        }
                    }    
                } while (itemSelecionado == 0);

                Console.WriteLine("----------------------------------");
                this._pedidos.Add(cardapio[itemSelecionado -1]);
                foreach (string? items in _pedidos)
                {
                    Console.WriteLine(items);
                }

                Console.Write("-Deseja adicionar mais um item? ");
                addMaisUmItem = Console.ReadLine();
                _continue = addMaisUmItem == "s" || addMaisUmItem == "S";
            }
            return _pedidos;
        }

        private string? SetName()
        {
            Console.Clear();
            Console.Write("Qual nome será registrado no pedido? ");
            _name = Console.ReadLine();
            return _name;
        }
        public List<string?> GetPedidos() => SetPedidos();
        public string? GetName() => SetName();
    }
}
