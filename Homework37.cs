using System;

namespace Homework37
{
    class Homework37
    {
        static void Main(string[] args)
        {
            string name = "Andrey";
            int level = 21;
            string className = "Thief";
            Player player = new Player(name, level, className);

            player.ShowInfo();
        }
    }

    class Player
    {
        private string _name;
        private int _level;
        private string _class;

        public Player(string name, int level, string playerClass)
        {
            _name = name;
            _level = level;
            _class = playerClass;
        }

        public Player()
        {
            _name = "Jhon Doe";
            _level = 20;
            _class = "Mage";
        }

        public void ShowInfo()
        {
            Console.WriteLine("Карточка игрока: \nимя - " + _name + "\nуровень - " + _level + "\nкласс - " + _class);
        }
    }
}
