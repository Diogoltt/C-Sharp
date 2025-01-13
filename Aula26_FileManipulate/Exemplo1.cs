namespace Aula26_FileManipulate
{
    public class Exemplo1
    {
        static void Exe1()
        {
            const string FilePath = @"C:\Users\diogogomes\Documents\Arquivos\Teste1.txt"; 
            // File é uma classe estática que contém métdos para manipulação de arquivos

            string FinalFile = @"C:\Users\diogogomes\Documents\Arquivos\Teste2.txt";

            try
            {
                var file = new FileInfo(FilePath);
                file.CopyTo(FinalFile);
                
                string[] line = File.ReadAllLines(FilePath);
                foreach (var lines in line)
                {
                    System.Console.WriteLine(lines);
                }
            }
            catch (IOException e) // Tratamento de erro especifico para manipular arquivo
            {
                System.Console.WriteLine("Ocorreu um erro");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}