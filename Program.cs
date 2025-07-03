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
            string name, age, placeOfBirth, profession, hobby, favoriteSchoolSubject, purposeInLife;
            Console.WriteLine("Здравствуйте! Вы приглашены в гости в Урганту! Перед передачей необходимо ответить на несколько вопросов. Давайте начнем.");
            Console.Write("Как Вас зовут? ");
            name = Console.ReadLine();
            Console.Write("Сколько Вам лет? ");
            age = Console.ReadLine();
            Console.Write("Где Вы родились? ");
            placeOfBirth = Console.ReadLine();
            Console.Write("Кто Вы по профессии? ");
            profession = Console.ReadLine();
            Console.Write("Какое у Вас хобби? ");
            hobby = Console.ReadLine();
            Console.Write("Какой предмет в школе был у вас любимым? ");
            favoriteSchoolSubject = Console.ReadLine();
            Console.Write("Какая у Вас цель в жизни? ");
            purposeInLife = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Вас зовут {name}, Вам {age}, Вы родились {placeOfBirth}, по профессии Вы {profession}, ваше хобби {hobby}, " +
                $"в школе Ваш любимый предмет был {favoriteSchoolSubject}, ваша цель в жизни {purposeInLife}.");
        }
    }
}
