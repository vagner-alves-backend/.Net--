using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacioamento_Main_VersãoFinal.Models
{
    public static class IsNumber
    {
        public static decimal Number(string? valueText)
        {
            decimal number = 0;
            while (!decimal.TryParse(valueText, out decimal notNumber))
            {
                Console.WriteLine("\t[Erro]:Valor invalido.");
                Console.Write("Por favor, informe um valor válido..: ");
                valueText = Console.ReadLine();
            }
            number = Convert.ToDecimal(valueText);
            return number;
        }
    }
}
