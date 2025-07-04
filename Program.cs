using System;

namespace hw7
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            int appointmentDurationMinutes = 10;
            int minutesInHour = 60;

            Console.Write("Сколько людей в очереди? ");
            int peopleInQueue = Convert.ToInt32(Console.ReadLine());

            int queueTimeInMinutetes = peopleInQueue * appointmentDurationMinutes;

            int hoursInQueue = queueTimeInMinutetes / minutesInHour;
            int minutesInQueue = queueTimeInMinutetes % minutesInHour;

            Console.WriteLine($"Вы должны отстоять в очереди {hoursInQueue} часов и {minutesInQueue} минут.");
        }
    }
}
