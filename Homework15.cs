using System;

namespace Homework15
{
    class Program
    {
       static void Main()
        {
            int maximumMultiple = 999;
            int lengthNuber = 3;
            int randomStart = 0;
            int randomFinish = 28;
            int countNumber = 0;
            Random random = new Random();
            int randomNumber = random.Next(randomStart, randomFinish);
            Console.WriteLine(randomNumber);

            for (int i = randomNumber; i < maximumMultiple; i += randomNumber)
            {
                if(Convert.ToString(i).Length >= lengthNuber)
                {
                    countNumber++;
                }
            }
            Console.WriteLine(countNumber);
        }
    }
}
