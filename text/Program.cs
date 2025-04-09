using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Введите длину пароля:");
                if (int.TryParse(Console.ReadLine(), out int length) && length > 0)
                {
                    string password = GeneratePassword(length);
                    Console.WriteLine($"Сгенерированный пароль: {password}");
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите корректную длину пароля.");
                }
            
        }
        static string GeneratePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
            Random random = new Random();
            char[] chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }

            return new string(chars);
        }
    }
}
