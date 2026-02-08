using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetSerializacaoDeDados_JSON.Models
{
    public class Pessoa(string name, int idade, string dataNacimento)
    {
        public string Name = name;
        public int Idade = idade;
        public string DataNascimento = dataNacimento;
    }
}
