using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudandoTuplas.Models
{
    public class TuplasEmMetodos
    {
        public (bool sucesso, string[] linhas, int qunatidadeDeLinhas) LerArquivo ()
        {
            try
            {
                string[] linhas = File.ReadAllLines("C:\\Users\\Vágner Alves\\OneDrive\\Documentos\\DioMe-Curso-CSharp\\_Códigos-das-aulas\\_Modulos\\ExplorandoALinguagem-CSharp\\EstudandoTuplasTernarioDescontrutores\\EstudandoTuplas\\EstudandoTuplas\\Arquivos\\arquivo.txt");
                return (true, linhas, linhas.Length);
            } catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return (false, Array.Empty<string>(), 0);
            }
        }
    }
}
