namespace Aula26_FileManipulate
{
    public class Exemplo6
    {
        static void Main(string[] args)
        {
            string PathFile = @"C:\Users\diogogomes\Documents\Arquivos\teste.txt";
            System.Console.WriteLine($"Directory Separator Char: {Path.DirectorySeparatorChar}");
            System.Console.WriteLine($"Separador de caminho: {Path.PathSeparator}");
            System.Console.WriteLine($"Retorna o diretório do arquivo: {Path.GetDirectoryName(PathFile)}");
            System.Console.WriteLine($"Retorna o nome do arquivo: {Path.GetFileName(PathFile)}");
            System.Console.WriteLine($"Retorna o nome do arquivo sem extensão: {Path.GetFileNameWithoutExtension(PathFile)}");
            System.Console.WriteLine($"Retorna a extensão do arquivo: {Path.GetExtension(PathFile)}");
            
        }
    }
}