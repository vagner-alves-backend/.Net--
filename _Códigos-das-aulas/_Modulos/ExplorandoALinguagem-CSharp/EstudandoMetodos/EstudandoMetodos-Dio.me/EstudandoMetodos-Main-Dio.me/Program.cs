using EstudandoMetodos_Main_Dio.me.Models;

Pessoa pessoa;
Curso matriculas = new();
bool continuar = true;

string? opcaoMenu = "";
string? name = "";
string? curso = "";
Console.Clear();
do
{
    Console.Write(
        "--\tMenu\n"+
        "[1] Adiconar\n"+
        "[2] Lista\n"+
        "[3] Remover\n"+
        "[4] Finalizar..: "
    );
    opcaoMenu = Console.ReadLine();
    Console.Clear();
    switch (opcaoMenu)
    {
        case "1":
            Console.Write("Name..: ");
            name = Console.ReadLine();
            Console.Write("Curso.: ");
            curso = Console.ReadLine();
            pessoa = new(name, curso);
            matriculas.AdicionarAluno(pessoa);
            break;
        case "2":
            matriculas.ListaAlunos();
            break;
        case "3":
            matriculas.RemoverAluno(matriculas.Aluno[0]);
            break;
        case "4":
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção Invalida, por favor informe uma opção valida.");
            break;
    }
} while (continuar);
