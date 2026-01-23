using DesafioEstacioamento_Main_VersãoFinal.Models;

Estacionamento estacionamento;

decimal precoInicias = 0;
decimal precoPorHora = 0;

Console.Clear();
Console.WriteLine("\n\t--Seja bem vindo ao sistema de estacionamento!--");
Console.WriteLine("-------------------------------------------------------------------------");
Console.Write("-Informe o preço inicial..: ");
precoInicias = IsNumber.Number(Console.ReadLine());
Console.Write("Informe o valor por horas..: ");
precoPorHora = IsNumber.Number(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Os valores passados foram -- Inicial : {precoInicias:C}  -  Por horas : {precoPorHora:C}");
Console.WriteLine("-------------------------------------------------------------------------");

estacionamento = new(precoInicias, precoPorHora);

bool exibirMenu = true;
string? opcao = "";
while (exibirMenu)
{
    Console.Write(
        "\t-Digite a sua opção.:\n"+
        "1 - Cadastrar veículo\n"+
        "2 - Remover veículo\n"+
        "3 - Listar veículos\n"+
        "4 - Encerrar..: "
    );
    opcao = Console.ReadLine();

    Console.Clear();
    Console.WriteLine($"Os valores passados foram -- Inicial : {precoInicias:C}  -  Por horas : {precoPorHora:C}");
    Console.WriteLine("-------------------------------------------------------------------------");

    switch (opcao)
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3":
            estacionamento.ImprimirPlacas();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("--Opção não encontrada.");
            break;
    }
    Console.WriteLine("-------------------------------------------------------------------------");
}
Console.Clear();
Console.WriteLine("Fim do programa.");
