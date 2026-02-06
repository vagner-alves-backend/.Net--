using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ProjetoComTuplas.Models
{
    public class Restaurante
    {
        private readonly string _filePath = "Arquivos\\cardapio.txt";
        private List<string?> SetCardapio()
        {
            List<string?> cardapio = [];
            try
            {
                string[]? arquivoDoCardapio = File.ReadAllLines(this._filePath);
                foreach (string? item in arquivoDoCardapio)
                {
                    cardapio.Add(item);
                }
            } catch(Exception ex) 
            {
                Console.Clear();
                Console.WriteLine($"[Erro]: {ex.Message}");
            }
            return cardapio;
        }

        private decimal Conta(List<string?> pedidos)
        {
            decimal total = 0;
            foreach (string? item in pedidos)
            {
                switch (item)
                {
                    case "Hambúrguer......R$ 35,54":
                        total += 35.54M;
                        break;
                    case "Pizza...........R$ 68,99":
                        total += 68.99M;
                        break;
                    case "HotDog..........R$ 23,45":
                        total += 23.45M;
                        break;
                    case "Batata-Frita....R$ 17,00":
                        total += 17.00M;
                        break;
                    case "Coca-cola.......R$ 14,99":
                        total += 14.99M;
                        break;
                    case "Suco............R$ 3,0":
                        total += 3.0M;
                        break;
                    default:
                        total += 0;
                        break;
                }
                // total = item switch
                // {
                //     "Hambúrguer......R$ 35,54" => total+=35.54M,
                //     "Pizza...........R$ 68,99" => total+=68.99M,
                //     "HotDog..........R$ 23,45" => total+=23.45M,
                //     "Batata-Frita....R$ 17,00" => total+=17M,
                //     "Coca-cola.......R$ 14,99" => total+=14.99M,
                //     "Suco............R$ 3,0" => total+=3
                //     _ => total+=0M
                // };
            }
            return total;
        }

        public List<string?> GetCardapio() => SetCardapio();
        public decimal GetSomaConta(List<string?> pedidos) => Conta(pedidos);
    }
}