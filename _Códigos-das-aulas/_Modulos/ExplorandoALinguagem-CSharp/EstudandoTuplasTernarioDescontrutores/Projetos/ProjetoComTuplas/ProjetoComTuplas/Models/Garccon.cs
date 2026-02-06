using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ProjetoComTuplas.Models
{
    public class Garccon : Cliente
    {
        private readonly List<(string? name, List<string?>)> _comandas = new();
        public void SetComanda()
        {
            _comandas.Add(new(GetName(), new(GetPedidos())));
        }

        public void PrintComandas()
        {
            if (_comandas.Count != 0)
            {
                foreach ((string? name, List<string?> pedidos) in _comandas)
                {
                    Console.WriteLine($"---{name}");
                    foreach (string? item in pedidos)
                    {
                        Console.WriteLine($"\t-{item}");
                    }
                }   
            } else
            {
                Console.WriteLine("Não a comandas registradas.");
            }
        }
    }
}
