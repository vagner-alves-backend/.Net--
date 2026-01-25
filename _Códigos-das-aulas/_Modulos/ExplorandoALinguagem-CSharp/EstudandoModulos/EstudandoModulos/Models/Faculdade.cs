using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudandoModulos.Models
{
    public class Faculdade
    {
        private readonly List<string?> _admins = ["Lucas", "Matheus", "Laura"];
        private readonly List<string?> _senhas = ["123", "123", "123"];

        private string? _name = "";
        private readonly string? _curso = "";
        private string? _senha = "";

        public Faculdade() : this("NaN", "NaN", "NaN") {}
        public Faculdade(string? name, string? senha) : this(name, "NaN", senha) {}
        public Faculdade(string? name, string? curso, string? senha)
        {
            _name = name;
            _curso = curso;
            _senha = senha;
        }

        public void GetName(string? name) => _name = name;
        public void GetSenha(string? senha) => _senha = senha;

        public bool GetAdmin()
        {
            bool isName = false;
            bool isSenha = false;
            bool loginValid = false;
            foreach (string? adm in _admins)
            {
                if (adm == _name)
                {
                    isName = true;
                }
            }

            foreach (string? senhas in _senhas)
            {
                if (senhas == _senha)
                {
                    isSenha = true;
                }
            }

            if (isName == true && isSenha == true)
            {
                loginValid = true;
            }

            return loginValid;
        }
    }
}
