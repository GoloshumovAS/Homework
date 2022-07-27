using System;
namespace Homework23
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[30];
            Random randomNumber = new Random();
            int countRep = 1;
            int countMax = 0;
            int finishVal = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(0, 5);
                Console.Write(array[i] + " ");
            }

            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] == array[i-1])
                {
                    countRep++;
                }
                else
                {
                    countRep = 1;
                    
                }
                if (countRep > countMax)
                {
                    countMax = countRep;
                    finishVal = array[i];
                }
            }

            for(int i = 0; i < countMax; i++)
            {
                Console.Write(finishVal);
            }
        }
    }
}
