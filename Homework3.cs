using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictureCount = 52;
            int rowSize = 3;
            int availableRow = pictureCount / rowSize;
            int unusedPictures = pictureCount % rowSize;
            Console.WriteLine($"Полностю заполненных рядов: {availableRow}," +
                $" неиспользуемых картинок: {unusedPictures}");
        }
    }
}
