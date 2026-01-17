using System.Runtime.InteropServices;
using DesafioEstacioamento_ModelsClass_MinhaVersao.Models;

ToAddVehicle add = new()
{
    Name = "Null",
    ParkingSpaces = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
};

ListVacancyParking list = new()
{
    Name = ["Null", "Null", "Null", "Null", "Null", "Null", "Null", "Null", "Null", "Null"],
    Vehicle = ["Null", "Null", "Null", "Null", "Null", "Null", "Null", "Null", "Null", "Null"],
    Vacancy = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
};

bool finishTask = false;
bool optionValid = false;

string? optionSelected = "Null";
string? removeVehicle = "Null";
string? name = "Null";

int optionChosen = 0;
int returnOption = 0;
int parkingFree = 0;
int vacancy = 0;
int vacancyReleased = 0;

Console.Clear();
do
{
    do
    {
        //  Opções do menu
        Console.WriteLine(
            "---\tSettings\n"+
            "1- To add\n"+
            "2- Remove\n"+
            "3- Search\n"+
            "4- List\n"+
            "5- End");
        optionSelected = Console.ReadLine();

        // Tratando dados recebidos ---optionSelected
        optionValid = int.TryParse(optionSelected, out returnOption);
        if (optionValid == false)
        {
            Console.WriteLine("\t[Erro]: Informe um valor valido...");
        } else
        {
            optionChosen = Convert.ToInt32(optionSelected);
            if (optionChosen < 1 || optionChosen > 5)
            {
                Console.WriteLine("\tOpção invalida, favor informe uma opção presente no menu.");
                optionValid = false;
            }
        }
    } while (!optionValid);

    Console.Clear();

    switch (optionChosen)
    {
        case 1: //  To add ---Adicionar.
            Console.WriteLine("Name: ");
            add.Name = Console.ReadLine();

            parkingFree = add.FreeVacancy();
            if (parkingFree != 404)
            {
                vacancy = parkingFree +1;
                Console.WriteLine("-Qual é seu veiculo? ");
                list.Vehicle[parkingFree] = Console.ReadLine();

                Console.WriteLine($"Sua vaga é a --{vacancy}");
                add.ParkingSpaces[parkingFree] = vacancy;
                list.Vacancy[parkingFree] = vacancy;
                list.Name[parkingFree] = add.Name;
            }
            break;

        case 2: // Remover veiculo.. -Remove vehicle.
            Console.WriteLine("Qual vaga deseja liberar? ");
            removeVehicle = Console.ReadLine();
            optionValid = int.TryParse(removeVehicle, out returnOption);
            if (optionValid == false)
            {
                Console.WriteLine("\t[Erro]: Valor invalido, tente novamente.");
            } else
            {
                vacancyReleased = Convert.ToInt32(removeVehicle);
                if (vacancyReleased < 1 || vacancyReleased > 10)
                {
                    Console.WriteLine("Vaga não encontrada.");
                } else
                {
                    Console.WriteLine(
                        $"Os dados relacionados a vaga {vacancyReleased} são: \n"+
                        $"Name: {list.Name[vacancyReleased -1]}\n"+
                        $"Veiculo: {list.Vehicle[vacancyReleased -1]}\n"
                    );
                    Console.WriteLine(
                        "-Deseja liberar essa vaga?\n "+
                        "[S/N]:"
                    );
                    removeVehicle = Console.ReadLine();

                    if (removeVehicle == "s" || removeVehicle == "S")
                    {
                        Console.WriteLine($"A vaga {vacancyReleased} foi liberada com sucesso.");
                        add.ParkingSpaces[vacancyReleased -1] = 0;
                        list.Name[vacancyReleased -1] = "Null";
                        list.Vehicle[vacancyReleased -1] = "Null";
                    } else
                    {
                        Console.WriteLine("Remoção interrompida.");
                    }
                }
            }
            break;

        case 3: // Busca registros
            Console.WriteLine("--Busca.Name..: ");
            name = Console.ReadLine();
            for (int index = 0; index < 10; index++)
            {
                if (list.Name[index] == name)
                {
                    Console.WriteLine($"Registro encontrado --Vaga: {index + 1}\n");
                    break;
                } else if (index == 9)
                {
                    Console.WriteLine("\t-Nome não encontrado no sistema.");
                }
            }
            break;
        
        case 4: // List vehicles
            list.PrintDataParking();
            break;
        case 5: // End progam
            finishTask = true;
            break;
    }
} while (!finishTask);


/*         
        Obs..: Para que minha versão não fosse influenciada, eu a desenvolvi antes de assistir às aulas relacionadas ao projeto.
        Portanto, caso eu tenha cometido algum erro na minha versão ou tenha feito algo desnecessário, isso não tem a influência do
        professor, tudo foi feito apenas pela minha própria lógica no momento. 
        --Caso deseje ver a versão desse mesmo projeto feita com o auxílio do professor, basta conferir na pasta com ess -e projeto que 
        não tenha escrito [ MinhaVersão ] no final.
*/
