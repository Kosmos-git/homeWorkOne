using System;

namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandRubToUsd = "RubToUsd";
            const string CommandUsdToRub = "UsdToRub";
            const string CommandRubToCny = "RubToCny";
            const string CommandCnyToRub = "CnyToRub";
            const string CommandUsdToCny = "UsdToCny";
            const string CommandCnyToUsd = "CnyToUsd";
            const string CommandExit = "Exit";

            float rubInWallet;
            float usdToWallet;
            float cnyToWallet;

            float rubToUsd = 1f / 79;
            float usdToRub = 74;
            float rubToCny = 1f / 11;
            float cnyToRub = 10;
            float usdToCny = 7;
            float cnyToUsd = 1f / 7;

            float exchangeCurrencyCount;

            bool isWork = true;

            Console.WriteLine("Добро пожаловать в обменник валют!\n");

            Console.Write("Введите баланс рублей: ");
            rubInWallet = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите баланс долларов: ");
            usdToWallet = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите баланс юаней: ");
            cnyToWallet = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("\nОперации возможные в обменнике:\n\n" +
                $"{CommandRubToUsd} - обмнять рубли на доллары.\n" +
                $"{CommandUsdToRub} - обмнять доллары на рубли.\n" +
                $"{CommandRubToCny} - обмнять рубли на юани.\n" +
                $"{CommandCnyToRub} - обмнять юани на рубли.\n" +
                $"{CommandUsdToCny} - обмнять доллары на юани.\n" +
                $"{CommandCnyToUsd} - обмнять юани на доллары.\n\n" +
                $"{CommandExit} - выйти из обменника.\n\n\n");

            while (isWork)
            {
                Console.Write("Выберите необходимую операцию: ");

                switch (Console.ReadLine())
                {
                    case CommandRubToUsd:
                        Console.WriteLine("\nОбмен рублей на доллары.\n");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (rubInWallet >= exchangeCurrencyCount)
                        {
                            rubInWallet -= exchangeCurrencyCount;
                            usdToWallet += exchangeCurrencyCount * rubToUsd;
                            Console.WriteLine("\nОбмен успешно произведен.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nНедопустимое количество рублей.\n");
                        }
                        break;

                    case CommandUsdToRub:
                        Console.WriteLine("\nОбмен долларов на рубли.\n");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (usdToWallet >= exchangeCurrencyCount)
                        {
                            usdToWallet -= exchangeCurrencyCount;
                            rubInWallet += exchangeCurrencyCount * usdToRub;
                            Console.WriteLine("\nОбмен успешно произведен.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nНедопустимое количество долларов.\n");
                        }
                        break;

                    case CommandRubToCny:
                        Console.WriteLine("\nОбмен рублей на юани.\n");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (rubInWallet >= exchangeCurrencyCount)
                        {
                            rubInWallet -= exchangeCurrencyCount;
                            cnyToWallet += exchangeCurrencyCount * rubToCny;
                            Console.WriteLine("\nОбмен успешно произведен.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nНедопустимое количество рублей.\n");
                        }
                        break;

                    case CommandCnyToRub:
                        Console.WriteLine("\nОбмен юаней на рубли.\n");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (cnyToWallet >= exchangeCurrencyCount)
                        {
                            cnyToWallet -= exchangeCurrencyCount;
                            rubInWallet += exchangeCurrencyCount * cnyToRub;
                            Console.WriteLine("\nОбмен успешно произведен.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nНедопустимое количество юаней.\n");
                        }
                        break;

                    case CommandUsdToCny:
                        Console.WriteLine("\nОбмен долларов на юани.\n");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (usdToWallet >= exchangeCurrencyCount)
                        {
                            usdToWallet -= exchangeCurrencyCount;
                            cnyToWallet += exchangeCurrencyCount * usdToCny;
                            Console.WriteLine("\nОбмен успешно произведен.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nНедопустимое количество долларов.\n");
                        }
                        break;

                    case CommandCnyToUsd:
                        Console.WriteLine("\nОбмен юаней на доллары.\n");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (cnyToWallet >= exchangeCurrencyCount)
                        {
                            cnyToWallet -= exchangeCurrencyCount;
                            usdToWallet += exchangeCurrencyCount * cnyToUsd;
                            Console.WriteLine("\nОбмен успешно произведен.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nНедопустимое количество юаней.\n");
                        }
                        break;

                    case CommandExit:
                        isWork = false;

                        Console.WriteLine("\nЗавершение программы . . .");
                        break;

                    default:
                        Console.WriteLine("\nВыбрана неверная операция\n\n");
                        break;
                }
                Console.WriteLine($"Ваш баланс: {rubInWallet} рублей, {usdToWallet} долларов, {cnyToWallet} юаней.\n");
            }
        }
    }
}
