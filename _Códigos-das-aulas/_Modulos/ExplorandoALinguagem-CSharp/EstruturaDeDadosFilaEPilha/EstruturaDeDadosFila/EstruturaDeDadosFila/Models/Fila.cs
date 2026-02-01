using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaDeDadosFila.Models
{
    public class Fila
    {
        private readonly Queue<int> _fila = new();
        public void AddElement(string? elemento)
        {
            while (!int.TryParse(elemento, out _))
            {
                Console.Clear();
                Console.Write($"O elemento [{elemento}] não é valido,\nFavor informe um number..: ");
                elemento = Console.ReadLine();
            }
            _fila.Enqueue(Convert.ToInt32(elemento));
        }
        public void RemoveElement() => _fila.Dequeue();
        public void PrintList()
        {
            foreach (int number in _fila)
            {
                Console.Write($"[{number}] ");
            }
        }
    }
}
