using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacioamento_Main_VersãoFinal.Models
{
    public class Estacionamento
    {
        private readonly decimal _precoInicial;
        private readonly decimal _precoDasHoras;
        private readonly List<string?> _lista = [];
        private string? _placa = "";

        public Estacionamento(decimal precoInicias, decimal precoPorHora)
        {
            this._precoDasHoras = precoPorHora;
            this._precoInicial = precoInicias;
        }

        public void AdicionarVeiculo()
        {
            string? _placa;
            Console.Write("-Informe a placa do véiculo..: ");
            _placa = Console.ReadLine();
            _lista.Add(_placa);
        }

        public void RemoverVeiculo()
        {
            string? quantidadeDeHoras = "";
            int horas = 0;
            decimal valorFinal = 0;

            Console.Write("-Informe a placa do veiculo..: ");
            _placa = Console.ReadLine();
            if (_lista.Any(p => p == _placa))
            {
                Console.WriteLine("--O veículo foi encontrado.");
                Console.Write("Quantas horas o veículo ficou estacionado..: ");
                quantidadeDeHoras = Console.ReadLine();

                while(!byte.TryParse(quantidadeDeHoras, out byte valorInvalido))
                {
                    Console.WriteLine("Valor de horas invalio.");
                    Console.Write("Por favor, informe um valor valido..: ");
                    quantidadeDeHoras = Console.ReadLine();
                }

                horas = Convert.ToInt32(quantidadeDeHoras);
                valorFinal = horas * (_precoDasHoras + _precoInicial);

                _lista.Remove(_placa);
                
                Console.WriteLine($"O veículo com a placa {_placa}, foi removido. O valor a ser pago é {valorFinal,5:C}");
            } else
            {
                Console.WriteLine("A placa informada não foi encontrada.");
            }
        }

        public void ImprimirPlacas()
        {
            Console.WriteLine("...........................");
            Console.WriteLine("As placas presentes são..: ");
            if (_lista.Count == 0)
            {
                Console.WriteLine("\t\t-Não a placas.");
            } else
            {
                foreach (string? placas in _lista)
                {
                    Console.WriteLine($"\t{placas}");
                }    
            }
            Console.WriteLine("...........................");
        }
    }
}
