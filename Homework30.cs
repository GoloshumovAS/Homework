using System;

using System;
//Сделать игровую карту с помощью двумерного массива.
//Сделать функцию рисования карты. 
//Помимо этого, дать пользователю возможность перемещаться по карте и взаимодействовать с элементами (например пользователь не может пройти сквозь стену)

//Все элементы являются обычными символами
namespace Homework30
{
    class Homework30
    {
        static void Main()
        {
            Console.CursorVisible = true;
            Console.WriteLine("Введите размер карты по X: ");
            int mapSizeByX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер карты по Y: ");
            int mapSizeByY = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            char[,] map = CreateMap(mapSizeByX, mapSizeByY);
            Console.SetCursorPosition(0, map.GetLength(1) + 5);
            Console.Write("Для управления используйте клавиши W A S D\n" +
                "Для выхода нажмите Enter");

            Console.CursorVisible = false;
            int playerPositionX = 1;
            int playerPositionY = 1;
            int playerDirectionX = 0;
            int playerDirectionY = 0;

            while (true)
            {
                PlayGame(map, ref playerPositionX, playerDirectionX, ref playerPositionY, playerDirectionY);
            }
        }

        static char[,] CreateMap(int x, int y)
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
            return map;
        }

        static void PlayGame(char[,] map, ref int playerPositionX, int playerDirectionX, ref int playerPositionY, int playerDirectionY)
        {
            CreatePlayer(ref playerPositionX, playerDirectionX, ref playerPositionY, playerDirectionY, map);
        }

        static void CreatePlayer(ref int playerPositionX, int playerDirectionX, ref int playerPositionY, int playerDirectionY, char[,] map)
        {
            GetDirection(ref playerDirectionX, ref playerDirectionY);
            CheckBorder(ref playerPositionX, playerDirectionX, ref playerPositionY, playerDirectionY, map);


        }

        static void GetDirection(ref int playerDirectionX, ref int playerDirectionY)
        {

            if (Console.KeyAvailable)
            {

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.W:
                        playerDirectionX = 0;
                        playerDirectionY = -1;
                        break;
                    case ConsoleKey.S:
                        playerDirectionX = 0;
                        playerDirectionY = 1;
                        break;
                    case ConsoleKey.A:
                        playerDirectionX = -1;
                        playerDirectionY = 0;
                        break;
                    case ConsoleKey.D:
                        playerDirectionX = 1;
                        playerDirectionY = 0;
                        break;
                }
            }
        }

        static void CheckBorder(ref int playerPositionX, int playerDirectionX, ref int playerPositionY, int playerDirectionY, char[,] map)
        {
            if (map[playerPositionX + playerDirectionX, playerPositionY + playerDirectionY] != '#')
            {
                Console.SetCursorPosition(playerPositionX, playerPositionY);
                Console.Write(' ');

                playerPositionX += playerDirectionX;
                playerPositionY += playerDirectionY;

                DrawPlayer(playerPositionX, playerPositionY);
            }
        }

        static void DrawPlayer(int playerPositionX,int playerPositionY)
        {
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write("%");
        }
    }
}
