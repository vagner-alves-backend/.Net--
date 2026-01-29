//Normalmente a localização é definida de forma altomatica, usando as configurações do sistema, mas 
//para forçar essa mudança podemos usar o comando.:
using System.Globalization;
decimal valorMonetario = 1245.45M;
Console.WriteLine($"Por padrão do meu sistema..: {valorMonetario, 10:C}");
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
Console.WriteLine($"Sistema en-US..: {valorMonetario, 10:C}");

//Alterando a localização da cultura.:
Console.WriteLine($"Sistema es-ES..: {valorMonetario.ToString("C", new CultureInfo("pt-BR"))}");
