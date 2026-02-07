using Newtonsoft.Json;
using NugetSerializacaoDeDados_JSON.Models;

string? caminho = "C:\\Users\\Vágner Alves\\OneDrive\\Documentos\\DioMe-Curso-CSharp\\_Códigos-das-aulas\\_Modulos\\ExplorandoALinguagem-CSharp\\NugetSerializacaoDeDados-JSON\\NugetSerializacaoDeDados-JSON\\Arquivos\\arquivo.json";

Console.Clear();
Pessoa pessoa = new("Vágner Alves", 20, "06/03/2005");
string? serializacao = JsonConvert.SerializeObject(pessoa, Formatting.Indented);
Console.WriteLine(serializacao);

File.WriteAllText(caminho, serializacao);
