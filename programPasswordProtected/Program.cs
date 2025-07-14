using System;

namespace programPasswordProtected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "12348765";
            string passwordInput;
            int numberAttempts = 3;
            string secretMessage = "Коды запуска ракет";

            for (int i = 0; i < numberAttempts; i++)
            {
                Console.Write("Введите пароль: ");
                passwordInput = Console.ReadLine();

                if (passwordInput == password)
                {
                    Console.WriteLine(secretMessage);
                    break;
                }
                else
                {
                    Console.WriteLine($"Пароль не верный. Попыток осталось: {numberAttempts - i - 1}");
                }
            }
        }
    }
}
