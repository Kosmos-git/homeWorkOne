using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            float rublesInWallet;
            float dollarsInWallet;
            float yuanInWallet;

            int rubToUsd = 79, usdToRub = 74;
            int rubToCny = 11, cnyToRub = 10;
            int usdToCny = 7, cnyToUsd = 7;

            float exchangeCurrencyCount;
            bool isWork = true;

            Console.WriteLine("Добро пожаловать в обменник валют!\n");

            Console.Write("Введите баланс рублей: ");
            rublesInWallet = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите баланс долларов: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите баланс юаней: ");
            yuanInWallet = Convert.ToSingle(Console.ReadLine());

            string balance = $"Ваш баланс: {rublesInWallet} рублей, {dollarsInWallet} долларов, {yuanInWallet} юаней.\n";

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
                        if (rublesInWallet >= exchangeCurrencyCount)
                        {
                            rublesInWallet -= exchangeCurrencyCount;
                            dollarsInWallet += exchangeCurrencyCount / rubToUsd;
                            Console.WriteLine("\nОбмен успешно произведен.\n");
                            Console.WriteLine(balance);
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
                        if (dollarsInWallet >= exchangeCurrencyCount)
                        {
                            dollarsInWallet -= exchangeCurrencyCount;
                            rublesInWallet += exchangeCurrencyCount * usdToRub;
                            Console.WriteLine("\nОбмен успешно произведен.\n");
                            Console.WriteLine(balance);
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
                        if (rublesInWallet >= exchangeCurrencyCount)
                        {
                            rublesInWallet -= exchangeCurrencyCount;
                            yuanInWallet += exchangeCurrencyCount / rubToCny;
                            Console.WriteLine("\nОбмен успешно произведен.\n");
                            Console.WriteLine(balance);
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
                        if (yuanInWallet >= exchangeCurrencyCount)
                        {
                            yuanInWallet -= exchangeCurrencyCount;
                            rublesInWallet += exchangeCurrencyCount * cnyToRub;
                            Console.WriteLine("\nОбмен успешно произведен.\n");
                            Console.WriteLine(balance);
                        }
                        else
                        {
                            Console.WriteLine("\nНедопустимое количество юаней.\n");
                        }
                        break;
                        break;

                    case CommandUsdToCny:
                        Console.WriteLine("\nОбмен долларов на юани.\n");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                        if (dollarsInWallet >= exchangeCurrencyCount)
                        {
                            dollarsInWallet -= exchangeCurrencyCount;
                            yuanInWallet += exchangeCurrencyCount * usdToCny;
                            Console.WriteLine("\nОбмен успешно произведен.\n");
                            Console.WriteLine(balance);
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
                        if (yuanInWallet >= exchangeCurrencyCount)
                        {
                            yuanInWallet -= exchangeCurrencyCount;
                            dollarsInWallet += exchangeCurrencyCount / cnyToUsd;
                            Console.WriteLine("\nОбмен успешно произведен.\n");
                            Console.WriteLine(balance);
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
            }
        }
    }
}
