using System;
using System.Text;

namespace masteringCycles
{
    internal class MasteringCycles
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введите сообщение: ");
            string messageUser = Console.ReadLine();

            Console.Write("Введите количество циклов: ");
            int numberRepetitionsCycle = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberRepetitionsCycle; i++)
            {
                Console.WriteLine(messageUser);
            }
        }
    }
}
