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
            int mapPositionX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер карты по Y: ");
            int mapPositionY = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            char[,] map = CreateMap(mapPositionX, mapPositionY);
            PlayGame(map);
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
            
            Console.SetCursorPosition(0, map.GetLength(1) + 5);
            Console.Write("Для управления используйте клавиши W A S D\n" +
                "Для выхода нажмите Enter");
            return map;
        }

        static void PlayGame(char[,] map)
        {
            Console.CursorVisible = false;
            int playerPositionX = 1;
            int playerPositionY = 1;

            ControlToPlayer(playerPositionX, playerPositionY, map);

        }

        static void ControlToPlayer(int playerPositionX, int playerPositionY, char[,] map)
        {
            bool isPlaying = true;
            int playerDirectionX = 0;
            int playerDirectionY = 1;

            while (isPlaying)
            {
                DrawPlayer(playerPositionX,playerPositionY);
                PressKey(playerPositionX, playerPositionY, ref isPlaying);
                CheckPlayerPosition(playerPositionX, playerDirectionX, playerPositionY, playerDirectionY, map);
            }
        }

        static void PressKey(int playerDirectionX, int playerDirectionY, ref bool isPlaying)
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
                    case ConsoleKey.Enter:
                        Console.Clear();
                        return;
                        break;
                }
            }
        }

        static void CheckPlayerPosition(int playerPositionX, int playerDirectionX, int playerPositionY, int playerDirectionY, char [,] map)
        {
            
            if (map[playerPositionX + playerDirectionX, playerPositionY + playerDirectionY] != '#')
            {
                Console.SetCursorPosition(playerPositionX, playerPositionY);
                Console.Write(' ');

                playerPositionX += playerDirectionX;
                playerPositionY += playerDirectionY;

                Console.SetCursorPosition(playerPositionX, playerPositionY);
                Console.Write('%');
            }
        }
        
        static void DrawPlayer(int playerPositionX, int playerPositionY)
        {
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write("%");
        }
    }
}
