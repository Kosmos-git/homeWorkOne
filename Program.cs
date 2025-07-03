using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Здравствуйте! Вы приглашены в гости к Урганту! Перед передачей необходимо ответить на несколько вопросов. Давайте начнем.");

            Console.Write("Как Вас зовут? ");
            string name = Console.ReadLine();

            Console.Write("Сколько Вам лет? ");
            string age = Console.ReadLine();
            
            Console.Write("Кто Вы по профессии? ");
            string profession = Console.ReadLine();
            
            Console.Write("Какое у Вас хобби? ");
            string hobby = Console.ReadLine();
            
            Console.Write("Какой предмет в школе был у вас любимым? ");
            string favoriteSchoolSubject = Console.ReadLine();
            
            Console.Write("Какая у Вас цель в жизни? ");
            string purposeInLife = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine($"Вас зовут {name}.\nВам {age}.\nВаше хобби: {hobby}.\n" +
                $"Ваш любимый предмет в школе: {favoriteSchoolSubject}.\nВаша цель в жизни: {purposeInLife}.");
        }
    }
}
