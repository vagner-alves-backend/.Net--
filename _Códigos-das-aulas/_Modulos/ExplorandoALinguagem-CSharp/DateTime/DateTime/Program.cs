using System.Globalization;
using System.Reflection.Metadata;

string? dataAtual = "30/01/2026 15:11";
//Formatando datas com tryparseExact
bool validDate = DateTime.TryParseExact(
    dataAtual, "dd/MM/yyyy HH:mm",
    CultureInfo.InvariantCulture,
    DateTimeStyles.None, out DateTime data
);

if (validDate)
{
    Console.WriteLine($"Data valida..: {data}");
} else
{
    Console.WriteLine($"Data invalida..: {dataAtual}");
}

//      Formatação bruta de cpf ---
// string? cpf = "12334545667";
// string? moldeCpf = "###.###.###-##";
// int positionAlgarismo = 0;
// for (int index  = 0; index < 14; index++)
// {
//     if (moldeCpf[index] == '#')
//     {
//         Console.Write(cpf[positionAlgarismo]);
//         positionAlgarismo++;
//     } else
//     {
//         Console.Write(moldeCpf[index]);
//     }
// }
