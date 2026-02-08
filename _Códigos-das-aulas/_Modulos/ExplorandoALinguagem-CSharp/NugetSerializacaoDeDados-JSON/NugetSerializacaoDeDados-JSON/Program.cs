using Newtonsoft.Json;
using NugetSerializacaoDeDados_JSON.Models;

string caminho = "C:\\Users\\Vágner Alves\\OneDrive\\Documentos\\DioMe-Curso-CSharp\\_Códigos-das-aulas\\_Modulos\\ExplorandoALinguagem-CSharp\\NugetSerializacaoDeDados-JSON\\NugetSerializacaoDeDados-JSON\\Arquivos\\arquivo.json";

Console.Clear();
// List<Pessoa> pessoa = [
//     new("Vágner Alves", 20, "06/03/2005"),
//     new("Lucas Mendes", 21, "07/05/2004"),
//     new("Sofia Lorenz", 18, "10/17/2007"),
//     new("Sabrine Gomes", 19, "04/11/2006")
// ];

// string? serializacao = JsonConvert.SerializeObject(pessoa, Formatting.Indented);
// Console.WriteLine(serializacao);
// File.WriteAllText(caminho, serializacao);
string conteudo = File.ReadAllText(caminho);
List<Pessoa> trasPessoas = JsonConvert.DeserializeObject<List<Pessoa>>(conteudo) ?? [];

Console.WriteLine("\tOs dados presentes nesse arquivo são ---");
Console.WriteLine("---------------------------------------------------------");
foreach (Pessoa pessoa_ in trasPessoas)
{
    Console.WriteLine($"{pessoa_.Name} tem {pessoa_.Idade} e nasceu em {pessoa_.DataNascimento}");
}
Console.WriteLine("---------------------------------------------------------");
