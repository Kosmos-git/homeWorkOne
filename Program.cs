using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            int timeOneAppointment = 10;
            int minutesInHour = 60;

            Console.Write("Сколько людей в очереди? ");
            int peopleInQueue = Convert.ToInt32(Console.ReadLine());

            int timeInQueue = peopleInQueue * timeOneAppointment;

            int hoursInQueue = timeInQueue / minutesInHour;
            int minutesInQueue = timeInQueue % minutesInHour;

            Console.WriteLine($"Вы должны отстоять в очереди {hoursInQueue} часов и {minutesInQueue} минут.");
        }
    }
}
