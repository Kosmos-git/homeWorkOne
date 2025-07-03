using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictures = 52;
            int picturesInRow = 3;
            int rowsFull;
            int picturesUnused;

            rowsFull = pictures / picturesInRow;
            picturesUnused = pictures % picturesInRow;

            Console.WriteLine($"Полностью заполненных рядов будет выведено: {rowsFull}");
            Console.WriteLine($"Картинок сверх меры будет: {picturesUnused}");
        }
    }
}
