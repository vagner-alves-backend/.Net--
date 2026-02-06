using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<string?> GetCardapio() => SetCardapio();
    }
}