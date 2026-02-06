using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoComTuplas.Models
{
    public class Garccon : Cliente
    {
        private List<(string? nome, List<string> pedidos)> _pedidos = [];
        public void AnotarComanda()
        {
            _pedidos.Add(new(name, Comanda()));
        }

        public void ImprimaAsComandas()
        {
            Console.Clear();
            if (_pedidos.Count > 0)  
            {
                int c = 0;
                while (c < _pedidos.Count)
                {
                    Console.WriteLine($"---{_pedidos[c].nome}");
                    foreach (string? item in _pedidos[c].pedidos)
                    {
                        Console.WriteLine($"\t-{item}");
                    }
                    Console.WriteLine("-------------------------");
                    c++;
                }
            }
        }
    }
}
