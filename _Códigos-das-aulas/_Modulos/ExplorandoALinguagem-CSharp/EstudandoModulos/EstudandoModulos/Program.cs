using EstudandoModulos.Models;

Console.Clear();

CheckLogin login = new();

string? nivelUser = "invalido";
bool loginValid = false;

nivelUser = login.Logar();
loginValid = login.VerifiqueLogin();
while (loginValid)
{
    switch(nivelUser)
    {
        case "admin":
            login.PrivilegiosDeAdm();
            break;
        case "professor":
            break;
        case "aluno":
            Console.WriteLine("Entrou.");
            Console.ReadLine();
            break;
        default:
            Console.WriteLine("\t-Login não é valido.");
            loginValid = false;
            break;
    }
    nivelUser = login.Logar();
    loginValid = login.VerifiqueLogin();
}
