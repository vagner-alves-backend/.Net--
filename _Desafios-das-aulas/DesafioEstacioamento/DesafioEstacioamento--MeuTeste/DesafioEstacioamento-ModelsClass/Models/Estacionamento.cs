using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacioamento_ModelsClass.Models
{
    public class Estacionamento
    {
        public int PrecoInicial {get; set;}
        public int PrecoDasHoras {get; set;}
        public List<string?> ListaDosVeiculos = [];

        public void RemoverVeiculo(string? placa, int horas)
        {
            for (int index = 0; index < ListaDosVeiculos.Count; index++)
            {
                if (placa == ListaDosVeiculos[index])
                {
                    ListaDosVeiculos.Remove(placa);
                    Console.WriteLine(
                        $"Placa: {placa}, foi removida...\n"+
                        $"Valor a ser pago..: R$ {PrecoInicial + (horas * PrecoDasHoras)}."
                    );
                    break;
                } else if (index == ListaDosVeiculos.Count -1)
                {
                    Console.WriteLine("\tPlaca não encontrada no sistema.");
                }
            }
        }

        public void ImprimirLista()
        {
            Console.WriteLine("\tPlacas..: ");
            foreach (string? placas in ListaDosVeiculos)
            {
                Console.WriteLine($"\t\t-{placas}");
            }
            Console.WriteLine("-------------------------------------------------\n");
        }
        
    }
}