using System;
//Сделать игровую карту с помощью двумерного массива.
//Сделать функцию рисования карты. 
//Помимо этого, дать пользователю возможность перемещаться по карте и взаимодействовать с элементами (например пользователь не может пройти сквозь стену)

//Все элементы являются обычными символами
namespace Homework30
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = true;
            Console.WriteLine("Введите размер карты по X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер карты по Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            char[,] map = PaintMap(x, y);
            Game(map);
        }

        static char[,] PaintMap(int x, int y)
        {
            char[,] map = new char[x, y];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.SetCursorPosition(i, j);
                    map[i, j] = '#';

                    if (i > 0 && i < map.GetLength(0) - 1 && j > 0 && j < map.GetLength(1) - 1)
                    {
                        map[i, j] = ' ';
                    }

                    Console.Write(map[i, j]);
                }
            }
            Console.SetCursorPosition(0, map.GetLength(1) + 5);
            Console.Write("Для управления используйте клавиши W A S D\n" +
                "Для выхода нажмите Enter");
            return map;
        }

        static void Game(char [,] map)
        {
            Console.CursorVisible = false;
            bool isPlaying = true;
            int playerX = 1;
            int playerY = 1;
            int playerGoX = 0;
            int playerGoY = 1;

            while (isPlaying)
            {
                Console.SetCursorPosition(playerX, playerY);
                Console.Write("%");

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.W:
                            playerGoX = 0;
                            playerGoY = -1;
                            break;
                        case ConsoleKey.S:
                            playerGoX = 0;
                            playerGoY = 1;
                            break;
                        case ConsoleKey.A:
                            playerGoX = -1;
                            playerGoY = 0;
                            break;
                        case ConsoleKey.D:
                            playerGoX = 1;
                            playerGoY = 0;
                            break;
                        case ConsoleKey.Enter:
                            return;
                            break;
                    }
                    if (map[playerX + playerGoX, playerY + playerGoY] != '#')
                    {
                        Console.SetCursorPosition(playerX, playerY);
                        Console.Write(' ');

                        playerX += playerGoX;
                        playerY += playerGoY;

                        Console.SetCursorPosition(playerX, playerY);
                        Console.Write('%');
                    }
                }
            }
        }
    }
}
