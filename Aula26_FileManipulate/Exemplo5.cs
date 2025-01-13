namespace Aula26_FileManipulate
{
    public class Exemplo5
    {
        static void Exe5()
        {
            string path = @"C:\Users\diogogomes\Documents\Arquivos\";

            try
            {   
                // Directory é uma classe estática que permite a manipulação dos diretórios
                // EnumerateDirectories que esta listando os diretórios
                // AllDirectories define a busca de todos os diretórios
                IEnumerable<string> pastas = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            
                System.Console.WriteLine("Pastas: ");
                foreach (string item in pastas)
                {
                    System.Console.WriteLine(item);
                }

                // Enumerar s arquivos
                IEnumerable<string> arquivos = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                foreach (string item in arquivos)
                {
                    System.Console.WriteLine(item);
                }

                Directory.CreateDirectory(path + @"\Teste2");
                
                // Directory.Delete(path + @"\NovaPasta");

                bool exists = Directory.Exists(path + @"\Teste2");
                System.Console.WriteLine(exists);
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu um erro");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}