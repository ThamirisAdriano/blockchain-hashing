using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string input = "Blockchain é fascinante!";
        Console.WriteLine($"Hash Original: {input}");

        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder hash = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                hash.Append(hashBytes[i].ToString("x2"));
            }
            Console.WriteLine($"Hash SHA256: {hash.ToString()}");
        }
    }
}

