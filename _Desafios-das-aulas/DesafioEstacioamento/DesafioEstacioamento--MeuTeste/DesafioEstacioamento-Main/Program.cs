using System.ComponentModel;
using DesafioEstacioamento_ModelsClass.Models;

Console.Clear();

Estacionamento estacionamento = new();
string? precoInicial = "Null";
string? precoDasHoras = "Null";

bool valorValido = false;
int valorDeRetorno = 0;
int horas = 0;
do
{
    Console.WriteLine("Qual o preço inicial..: ");
    precoInicial = Console.ReadLine();    
    valorValido = int.TryParse(precoInicial, out valorDeRetorno);
    if (valorValido == false)
    {
        Console.WriteLine("Apenas números são permitidos.");
    } else
    {
        estacionamento.PrecoInicial = Convert.ToInt32(precoInicial);
    }
} while (!valorValido);

do
{
    Console.WriteLine("Qual o preço das horas..: ");
    precoDasHoras = Console.ReadLine();    
    valorValido = int.TryParse(precoDasHoras, out valorDeRetorno);
    if (valorValido == false)
    {
        Console.WriteLine("Apenas números são permitidos.");
    } else
    {
        estacionamento.PrecoDasHoras = Convert.ToInt32(precoDasHoras);
    }
} while (!valorValido);

Console.Clear();
Console.WriteLine("Seja bem vindo ao sistema de estacionamento");
List<string?> veiculosEstacionados = [];

string? opcao = "Null";
string? placa = "Null";
string? horasInformadas = "Null";

bool encerrar = false;
bool opcaoSelecionada = false;

int opcaoEscolhida = 0;
int opcaoDeRetorno = 0;
do
{
    do
    {
        Console.WriteLine(
            "\t-Digite a sua opção..:\n"+
            "1° Cadastrar Veículo.\n"+
            "2° Remover Veículo.\n"+
            "3° Listar veículos.\n"+
            "4° Emcerrar.\n"+
            "-------------------------------------------------\n"
        );
        opcao = Console.ReadLine();
        opcaoSelecionada = int.TryParse(opcao, out opcaoDeRetorno);
        if (opcaoSelecionada == false)
        {
            Console.WriteLine("\t[Erro]: Apenas numeros são permitidos.");   
        } else
        {
            opcaoEscolhida = Convert.ToInt32(opcao);
            if (opcaoEscolhida < 1 || opcaoEscolhida > 4)
            {
                Console.WriteLine("\tOpção não existente.");
                opcaoSelecionada = false;
            }
        }
    } while (!opcaoSelecionada);

    switch (opcaoEscolhida)
    {
        case 1:
            Console.WriteLine("--Placa do veículo: ");
            placa = Console.ReadLine();
            Console.WriteLine($"\t-A placa {placa} foi registrada.");
            Console.WriteLine("-------------------------------------------------\n");
            estacionamento.ListaDosVeiculos.Add(placa);
            break;

        case 2:
            Console.WriteLine("--Qual placa deseja remover? ");
            placa = Console.ReadLine();

            do
            {
                Console.WriteLine("Quantas horas o veiculo ficou estacionado? ");
                horasInformadas = Console.ReadLine();
                valorValido = int.TryParse(horasInformadas, out valorDeRetorno);
                if (valorValido == false)
                {
                    Console.WriteLine("\t-Hora invalida...");
                } else
                {
                    horas = Convert.ToInt32(horasInformadas);
                }
            } while (!valorValido);

            Console.WriteLine("-------------------------------------------------\n");
            estacionamento.RemoverVeiculo(placa, horas);
            break;
        
        case 3:
            estacionamento.ImprimirLista();
            break;

        case 4:
            encerrar = true;
            break;
    }
    Thread.Sleep(2000);
    Console.Clear();
} while (!encerrar);
