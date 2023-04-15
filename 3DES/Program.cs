using _3DES;
using System.IO;
using System;
using System.Reflection;
using System.Security.Cryptography;

namespace TripleDES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A deshironi te enkriptoni tekst apo fajll: ");
            string input = Console.ReadLine();
            input = input.ToLower();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ju lutem pergjigjuni me 'text' ose 'file'");
                input = Console.ReadLine();
            }

            EncryptDecrypt(input);
            Console.WriteLine("A deshironi te perserisni ekzekutimin (y/n): ");
            string continueInput = Console.ReadLine();
            while (continueInput.ToLower() == "y")
            {
                Console.WriteLine("Ju lutem pergjigjuni me 'text' ose 'file'");
                input = Console.ReadLine();
                input = input.ToLower();

                while (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ju lutem pergjigjuni me 'text' ose 'file'");
                    input = Console.ReadLine();
                }

                EncryptDecrypt(input);

                Console.WriteLine("A deshironi te perserisni ekzekutimin (y/n): ");
                continueInput = Console.ReadLine();

            }

        }

        public static void EncryptDecrypt(string input)
        {
            if (input == "text")
            {
                Console.WriteLine("Shenoni tekstin: ");
                string plainText = Console.ReadLine();

                string encryptedText = TripleDes.Encrypt(plainText);
                string decryptedText = TripleDes.Decrypt(encryptedText);

                Console.WriteLine("Para enkriptimit = " + plainText + "\n");
                Console.WriteLine("Pas enkriptimit = " +
                   encryptedText + "\n");
                Console.WriteLine("Pas dekriptimit = " +
                   decryptedText + "\n");

            }
            else if (input == "file")
            {

                string workingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string path = System.IO.Path.Combine(workingDirectory, "text.txt");
                string readText = File.ReadAllText(path);

                string encryptedText = TripleDes.Encrypt(readText);
                string decryptedText = TripleDes.Decrypt(encryptedText);

                Console.WriteLine("Para enkriptimit = " + readText + "\n");
                Console.WriteLine("Pas enkriptimit = " +
                   encryptedText + "\n");
                Console.WriteLine("Pas dekriptimit = " +
                   decryptedText + "\n");

            }
        }
    }

}
