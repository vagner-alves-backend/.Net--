using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaDeDadosPilha.Models
{
    public class EstruturaPilha
    {
        private readonly Stack<int> _pilha = new();
        public void AddElement(string? element)
        {
            while(!int.TryParse(element, out _))
            {
                Console.Write($"O elemento [{element}] é invalido,\nInforme um elemento valido..: ");
                element = Console.ReadLine();
            }
            Console.WriteLine($"O elemento {element}, foi adicionado");
            Console.WriteLine("-----------------------------------------------");
            _pilha.Push(Convert.ToInt32(element));
        }

        public void RemoveElement() => Console.WriteLine($"O elemento {_pilha.Pop()}, foi removido.\n-----------------------------------------------");
        public void PrintList()
        {
            Console.WriteLine("Os elementos presentes na pilha são..:");
            foreach (int number in _pilha)
            {
                Console.Write($"[{number}] ");
            }
            Console.WriteLine("\n-----------------------------------------------");
        }
    }
}