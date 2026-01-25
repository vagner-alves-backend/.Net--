using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudandoModulos.Models
{
    public class Faculdade : Admin
    {
        private readonly List<Admin> _admins = [new("Lucas", "123"), new("Matheus", "123"), new("Laura", "123")];
        //private readonly List<Admin> _senhas = [];
        private readonly List<string?> _alunos = ["Vágner"];

        private string? _name = "";
        private string? _curso = "";
        private string? _senha = "";

        public Faculdade() : this("NaN", "NaN", "NaN") {}
        public Faculdade(string? name, string? senha) : this(name, "NaN", senha) {}
        public Faculdade(string? name, string? curso, string? senha)
        {
            _name = name;
            _curso = curso;
            _senha = senha;
        }

        public void SetName(string? name) => _name = name;
        public void SetSenha(string? senha) => _senha = senha;
        public void SetCurso(string? curso) => _curso = curso;

        public bool GetAdmin()
        {
            bool loginValido = false;
            for (int index = 0; index < _admins.Count; index++)
            {
                if (_admins[index].GetAdminName() == _name && _admins[index].GetAdminSenha() == _senha)
                {
                    loginValido = true;
                }
            }
            return loginValido;
        }
    }
}
