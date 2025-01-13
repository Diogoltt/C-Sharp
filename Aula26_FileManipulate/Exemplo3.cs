namespace Aula26_FileManipulate
{
    public class Exemplo3
    {
        static void Exe3()
        {
            const string FilePath = @"C:\Users\diogogomes\Documents\Arquivos\Teste1.txt"; 

            try
            {
                using (var fs = new FileStream(FilePath, FileMode.Open))
                {
                    using (var sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        System.Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                
                System.Console.WriteLine("Ocorreu um erro");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}