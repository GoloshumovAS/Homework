using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictureCount = 52;
            int rowSize = 3;
            int availablePictures = pictureCount / rowSize;
            int unusedPictures = pictureCount % rowSize;
            Console.WriteLine($"Полностю заполненных рядов: {availablePictures}," +
                $" неиспользуемых картинок: {unusedPictures}");
        }
    }
}
