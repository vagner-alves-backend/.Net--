using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudandoModulos.Models
{
    public class CheckLogin : Login
    {
        private string? _nivelDeAcesso;
        public string? Logar() {
            NivelUser();
            SetAcesso(_nivelDeAcesso);
            LoginUser();
            return _nivelDeAcesso;
        }
        private string? NivelUser()
        {
            Console.Clear();
            _nivelDeAcesso = "invalido";
            string? opcaoSelecionada;
            while(_nivelDeAcesso == "invalido")
            {
                Console.Write(
                    "-Deseja logar como..:\n"+
                    "1__Admin_______\n"+
                    "2__Professor___\n"+
                    "3__Aluno_______\n"+
                    "4__Finalizar_-> "
                );
                opcaoSelecionada = Console.ReadLine();
                _nivelDeAcesso = opcaoSelecionada switch
                {
                    "1" => "admin",
                    "2" => "professor",
                    "3" => "aluno",
                    "4" => "fim",
                    _ => "invalido"
                };
                Console.Clear();
            }

            return _nivelDeAcesso;
        }
    }
}