using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ivanov";
            string surname = "Leonid";
            string buffer;

            Console.WriteLine($"Исходное значение переменных:\nname = {name}\nsurname = {surname}");

            buffer = name;
            name = surname;
            surname = buffer;

            Console.WriteLine($"Значение переменных после перестановки:\nname = {name}\nsurname = {surname}");
        }
    }
}
