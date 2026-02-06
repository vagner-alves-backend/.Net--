bool _continue = false;
string? numberText = "";
int number = 0;
int resultado = 0;

Console.Clear();
do
{
    Console.Write("Informe um number par..: ");
    numberText = Console.ReadLine();
    Console.Clear();
    while (!int.TryParse(numberText, out _))
    {
        Console.Write("O valor informado não é um number,\nFavor informe um numbe -> ");
        numberText = Console.ReadLine();
    }
    number = Convert.ToInt32(numberText);
    resultado = number % 2;

    Console.WriteLine($"O número {number} é {(resultado == 0 ? "par" : "Impar")}");
    _continue = number % 2 == 1;
} while (_continue);
