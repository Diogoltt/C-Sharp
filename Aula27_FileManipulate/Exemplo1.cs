namespace Aula27_FileManipulate
{
    public class Exemplo1
    {
        static void Exe1()
        {
            string filePath = "dados.bin";

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(123);
                writer.Write(45.3546);
                writer.Write("Hello World");
            }

            System.Console.WriteLine("Dados gravados em: " + filePath);
        }
    }
}