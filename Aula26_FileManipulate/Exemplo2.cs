using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula26_FileManipulate
{
    public class Exemplo2
    {
        static void Exe2()
        {
            const string FilePath = @"C:\Users\diogogomes\Documents\Arquivos\Teste1.txt"; 
            FileStream fs = null; // Essa é uma classe que permite read/write de arquivos. Baixo nível
            StreamReader sr = null; // Manipulação de arquivo, mas alto nível
        
            try
            {
                fs = new FileStream(FilePath, FileMode.Open); // Abre o arquivo

                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                System.Console.WriteLine(line);

                while (line != null)
                {
                    line = sr.ReadLine();
                    System.Console.WriteLine(line);
                }
                
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu um erro");
                System.Console.WriteLine(e.Message);
            }
            finally
            {   // Necessário fechar os arquivos
                if (sr != null)
                    sr.Close();
                if (fs != null)
                    fs.Close();
            }
        }
    }
}