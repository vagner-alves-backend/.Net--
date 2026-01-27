using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudandoMetodos_Main_Dio.me.Models
{
    public class Pessoa(string? name, string? curso)
    {
        private string? _name = name;
        private string? _curso = curso;
        //protected Pessoa GetAluno() => new(_name, _curso);
        public string? GetAlunoName() => _name;
        public string? GetAlunoCurso() => _curso;

        public void SetAlunoName(string? name) => _name = name;
        public void SetAlunoCurso(string? curso) => _curso = curso;
    }
}
