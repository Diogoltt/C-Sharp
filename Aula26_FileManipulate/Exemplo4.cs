namespace Aula26_FileManipulate
{
    public class Exemplo4
    {
        static void Exe4()
        {
            const string FilePath = @"C:\Users\diogogomes\Documents\Arquivos\Teste1.txt";
            string FinalPath = @"C:\Users\diogogomes\Documents\Arquivos\Teste2.txt"; 

            try
            {
                string[] lines = File.ReadAllLines(FilePath);
                
                using (StreamWriter sw = File.AppendText(FinalPath))
                {
                    foreach (string item in lines)
                    {
                        sw.WriteLine(item.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu um erro");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}