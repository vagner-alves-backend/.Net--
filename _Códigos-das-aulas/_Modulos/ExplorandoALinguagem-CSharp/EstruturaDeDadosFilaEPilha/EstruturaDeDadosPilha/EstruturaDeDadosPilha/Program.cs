using EstruturaDeDadosPilha.Models;
Console.Clear();

EstruturaPilha pilha = new();
string? option = "";
bool _continue = true;
do
{
    Console.Write(
        "---Deseja..:\n"+
        "1-Adicionar,\n"+
        "2-Remover,\n"+
        "3-Imprimir,\n"+
        "4-Finalizar..: "
    );
    option = Console.ReadLine();
    Console.Clear();
    switch (option)
    {
        case "1":
            Console.Write("Qual number deseja adicionar a pilha..: ");
            pilha.AddElement(Console.ReadLine());
            break;
        case "2":
            pilha.RemoveElement();
            break;
        case "3":
            pilha.PrintList();
            break;
        case "4":
            _continue = false;
            break;
        default:
            Console.WriteLine($"[Erro]: A opção informada não foi encontrada,\nfavor informe uma opção valida.");
            break;
    }
} while (_continue);
