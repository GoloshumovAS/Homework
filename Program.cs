using System;
//Создать класс игрока, у которого есть поля с его положением в x, y.
//Создать класс отрисовщик, с методом, который отрисует игрока.
//Попрактиковаться в работе со свойствами.
namespace Homework38
{
    class Program
    {
        static void Main()
        {
            PositionPlayer player = new PositionPlayer();
            DrawPlayer draw = new DrawPlayer();
            draw.Draw(player.positionX,player.positionY);
        }
    }

    class PositionPlayer
    {
        public int positionX;
        public int positionY;

        public PositionPlayer()
        {
            positionX = 1;
            positionY = 1;
        } 
    }

    class DrawPlayer 
    {
        private string _gamer;
        
        public DrawPlayer()
        {
            _gamer = "%";
        }
        
        public void Draw(int positionX, int positionY)
        {
            Console.Clear();
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(_gamer);
        }
    }
}
