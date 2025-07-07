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

            bool exitProgram = true;
            string massageUser;
            string stopWord = "exit";

            while (exitProgram)
            {
                Console.Write("Введите желаемое сообщение: ");
                massageUser = Console.ReadLine();

                if (massageUser == stopWord)
                {
                    exitProgram = false;
                }
            }

            Console.WriteLine("\nПрограмма заввершена.\n");
        }
    }
}
