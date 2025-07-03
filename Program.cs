using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceCrystal = 25;
            Console.WriteLine($"Добро пожаловать в магазин кристаллов. Стоимость кристалла {priceCrystal} монет.");          

            Console.Write("Сколько у Вас монет? ");
            int money = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сколько кристаллов Вы хотите приобрести? ");
            int crystals = Convert.ToInt32(Console.ReadLine());

            money -= crystals * priceCrystal;
            Console.WriteLine($"У Вас в рюкзаке {crystals} кристаллов и {money} монет.");
        }
    }
}
