//string? caminho = "C:\\Users\\Vágner Alves\\OneDrive\\Documentos\\DioMe-Curso-CSharp\\_Códigos-das-aulas\\_Modulos\\ExplorandoALinguagem-CSharp\\Exceptions\\ExceptionsEmLeituraDeArquivos\\ExceptionsEmLeituraDeArquivos\\Arquivo\\arq.txt";

// string? texto = "Linha 1 - Essa é a linha 1.";
// File.WriteAllText(caminho, texto);

string pastaRaiz = AppContext.BaseDirectory;
string caminho = Path.Combine(pastaRaiz, "Arquivo/arq.txt");

Console.Clear();
try
{
    string[] linhas = File.ReadAllLines("Arquivo/arq.txt");
    foreach (string? linha in linhas)
    {
        Console.WriteLine(linha);
    }
} catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exception, {ex.Message}\n\n");    
}
