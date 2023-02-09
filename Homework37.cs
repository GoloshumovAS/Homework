using System;

namespace Homework37
{
    class Homework37
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.PlayerName = "Jhon Doe";
            player.PlayerLevel = 20;
            player.PlayerClass = "Mage";
            player.ShowInfo();
        }
    }

    class Player 
    {
        public string PlayerName;
        public int PlayerLevel;
        public string PlayerClass;

        public void ShowInfo()
        {
            Console.WriteLine("Карточка игрока: \nимя - " + PlayerName + "\nуровень - " + PlayerLevel + "\nкласс - " + PlayerClass);
        }
    }
}
