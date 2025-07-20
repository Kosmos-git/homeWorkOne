using System;

namespace workingWithSpecificRowsColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 6, 7, 8 }
            };

            int sumSecondRow = 0;
            int lineSecond = 1;

            int productFirstColumn = 1;
            int columnFirst = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                sumSecondRow += array[lineSecond, j];
            }

            Console.WriteLine("Сумма второй строки: " + sumSecondRow);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                productFirstColumn *= array[i, columnFirst];
            }

            Console.WriteLine("Произведение первого столбца: " + productFirstColumn);
        }
    }
}
