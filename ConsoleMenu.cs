using System;

namespace ConsoleMenu
{
    internal class ConsoleMenu
    {
        static void Main(string[] args)
        {
            bool exitProgram = true;
            Random random = new Random();

            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Привет! Это моя первая программа. Она называется: 'Консольное меню'\n");

            Console.WriteLine("Программа умеет выполнять следующие команды:\n\n" +
                "1 - Рассказать анекдот №1.\n\n" +
                "2 - Рассказать анекдот №2.\n\n" +
                "3 - Вывести случайное число.\n\n" +
                "4 - Очистить консоль.\n\n" +
                "5 - Повторить список команд, которые знает программа.\n\n" +
                "6 - Выход из программы.\n\n\n");

            while (exitProgram)
            {
                Console.Write("Введите команду, которую хотите выполнить: ");
                string commandNumber = Console.ReadLine();

                switch (commandNumber)
                {
                    case "1":
                        Console.WriteLine("\nПорой ты пытаешься показать свой богатый внутренний мир тому, у кого внутри посёлок городского типа.\n\n");
                        break;

                    case "2":
                        Console.WriteLine("\nПерейдём к действительно важным вопросам. Почему у Губки Боба нет зелёной шершавой штуки на спине?\n\n");
                        break;

                    case "3":
                        Console.Write("\nВведите нижнюю границу для случайного числа: ");
                        int minRandomNumber = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nВведите верхнюю границу для случайного числа: ");
                        int manRandomNumber = Convert.ToInt32(Console.ReadLine());

                        int randomNumber = random.Next(minRandomNumber, manRandomNumber);

                        Console.WriteLine($"\nВаше случайное число: {randomNumber}\n\n");
                        break;

                    case "4":
                        Console.Clear();
                        break;

                    case "5":
                        Console.WriteLine("\n\nНапоминаю список команд, которые программа умеет выполнять:\n\n" +
                            "1 - Рассказать анекдот №1.\n\n" +
                            "2 - Рассказать анекдот №2.\n\n" +
                            "3 - Вывести случайное число.\n\n" +
                            "4 - Очистить консоль.\n\n" +
                            "5 - Повторить список команд, которые знает программа.\n\n" +
                            "6 - Выход из программы.\n\n\n");
                        break;

                    case "6":
                        exitProgram = false;
                        
                        Console.WriteLine("\nЗавершение программы . . .");
                        break;

                    default:
                        Console.WriteLine("\nИзвините, но пока что я такой команды не знаю.\n\nПопробуйте еще раз.\n");
                        break;
                }
            }
        }
    }
}
