using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Aula27_FileManipulate
{
    public class Encripty
    {
        static void Exe4(string[] args)
        {
            string original = "original.txt";
            string encriptado = "encriptado.txt";
            string desencriptado = "desencriptado.txt";

            File.WriteAllText(original, "Este é o conteúdo do arquivo original");
            Console.WriteLine("Arquivo original criado");

            string password = "senhasecreta";
            
            EncriptyFile(original, encriptado, password);
            Console.WriteLine("Arquivo encriptado");

            DecryptFile(encriptado, desencriptado, password);
            Console.WriteLine("Arquivo desencriptado");
        }

        private static void EncriptyFile(string original, string encriptado, string password)
        {
            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));
        
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (FileStream inputFileStream = new FileStream(original, FileMode.Open))
                using (FileStream outputFileStream = new FileStream(encriptado, FileMode.Create))
                using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    inputFileStream.CopyTo(cryptoStream);
                }
            }
        }

        private static void DecryptFile(string encriptado, string desencriptado, string password)
        {
            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (FileStream inputFileStream = new FileStream(encriptado, FileMode.Open))
                using (FileStream outputFileStream = new FileStream(desencriptado, FileMode.Create))
                using (CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    cryptoStream.CopyTo(outputFileStream);
                }
            }
        }
    }
}
