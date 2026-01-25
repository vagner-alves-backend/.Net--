using EstudandoModulos.Models;

Console.Clear();

Login login;
string? opcaoSelecionada = "";
string? nivelUser = "invalido";

bool loginValid = false;

while(nivelUser == "invalido")
{
    Console.WriteLine(
        "-Deseja logar como..:\n"+
        "1- Admin.\n"+
        "2- Professor.\n"+
        "3- Aluno."
    );
    Console.Write("..: ");
    opcaoSelecionada = Console.ReadLine();
    nivelUser = opcaoSelecionada switch
    {
        "1" => "admin",
        "2" => "professor",
        "3" => "aluno",
        _ => "invalido"
    };
    Console.Clear();
}
login = new(nivelUser);
login.LoginUser();

loginValid = login.VerifiqueLogin();
while (loginValid && nivelUser == "admin")
{
    Console.Clear();
    Console.WriteLine(
        "\t-Admin\n"+
        "--------------------\n"+
        "1- Adicionar Aluno.\n"+
        "2- Adicionar Professor.\n"+
        "3- Remover Aluno.\n"+
        "4- Remover Professor."
    );
    Console.Write("..: ");
    opcaoSelecionada = Console.ReadLine();

    nivelUser = "";
}

