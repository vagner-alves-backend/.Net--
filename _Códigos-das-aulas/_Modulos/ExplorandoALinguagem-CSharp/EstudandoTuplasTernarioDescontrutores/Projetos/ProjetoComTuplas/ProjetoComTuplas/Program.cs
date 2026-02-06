using ProjetoComTuplas.Models;
Garccon garcon = new();

Console.Clear();
bool _continue = true;
string? opcao = "";
do
{
    Console.Write(
        "----Deseja..:\n"+
        "1- Anotar o pedido\n"+
        "2- Ver todas as notas\n"+
        "3- Finaliar programa\n"+
        "--> "
    );
    opcao = Console.ReadLine();
    Console.Clear();
    switch (opcao)
    {
        case "1":
            garcon.SetComanda();
            break;
        case "2":
            garcon.PrintComandas();
            break;
        case "3":
            _continue = false;
            break;
        default:
            Console.WriteLine("Opção não encontrada, favor informe uma opção existente.");
            break;
    }
    Console.WriteLine("----------------------------------");
} while (_continue);
