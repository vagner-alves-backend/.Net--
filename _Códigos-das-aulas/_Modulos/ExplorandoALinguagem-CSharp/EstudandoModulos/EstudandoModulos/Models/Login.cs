using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace EstudandoModulos.Models
{
    public class Login : Faculdade
    {
        private bool _loginValido = false;
        private readonly string? _nivelDeAcesso = "";
        public Login(string? acesso)
        {
            _nivelDeAcesso = acesso;
        }

        public void LoginUser()
        {
            Console.WriteLine(
                "\t-Login\n"+
                "--------------------"
            );
            switch (_nivelDeAcesso)
            {
                case "admin":
                    LoginAdmin();
                    break;
                case "professor":
                    Console.Write("-Nome...: \n");
                    Console.Write("-Curso..: \n");
                    Console.Write("-Senha..: \n");
                    break;
                case "aluno":
                    Console.Write("-Nome...: \n");
                    Console.Write("-Curso..: \n");
                    Console.Write("-Senha..: \n");
                    break;
                default:
                    Console.WriteLine("Nível de acesso não informado.");
                    break;
            }

        }

        private void LoginAdmin()
        {
            Console.Clear();
            Console.WriteLine(
                "-   Login Admin\n"+
                "--------------------"
            );
            Console.Write("-Name..: ");
            GetName(Console.ReadLine());
            Console.Write("-Senha.: ");
            GetSenha(Console.ReadLine());

            _loginValido = GetAdmin();
        }

        public bool VerifiqueLogin() => _loginValido;
    }
}
