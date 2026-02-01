using EstruturaDeDadosFila.Models;
Console.Clear();

Fila fila = new();
bool _continue = true;
do
{
    Console.Write(
        "---Deseja..: \n"+
        "1-Adicionar,\n"+
        "2-Remover,\n"+
        "3-Imprmir,\n"+
        "4-Finalizar..: "
    );
    switch (Console.ReadLine())
    {
        case "1":
            Console.Write("Qual number deseja adicionar a lista..: ");
            fila.AddElement(Console.ReadLine());
            break;
        case "2":
            fila.RemoveElement();
            break;
        case "3":
            fila.PrintList();
            Console.ReadLine();
            break;
        case "4":
            _continue = false;
            break;
        default:
            Console.WriteLine("[Erro]: Opção não encontrada, favor informe uma opção valida.");
            break;
    }
    Console.Write("\n-------------------------\n->");
    Console.Clear();
} while (_continue);
