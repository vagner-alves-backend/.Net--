using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoComTuplas.Models
{
    public class Restaurante
    {
        private readonly string _filePath = "Arquivos\\cardapio.txt";
        public string[] GetCardapio()
        {
            string[] cardapio = [];
            try
            {
                cardapio = File.ReadAllLines(_filePath);
            } catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível abrir o cardapio.\n[Erro]: {ex.Message}");
            }
            return cardapio;
        }
    }

    
}
