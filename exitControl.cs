using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exitControl
{
    internal class exitControl
    {
        static void Main(string[] args)
        {
            Console.Write("Программа позволяет ввести любое сообщение. Для завершения введите: 'exit'.\n\n");

            string massageUser;
            string exitProgram = "exit";

            while (true)
            {
                Console.Write("Введите желаемое сообщение: ");
                massageUser = Console.ReadLine();

                if (massageUser == exitProgram)
                {
                    break;
                }
            }

            Console.WriteLine("\nПрограмма заввершена.\n");
        }
    }
}
