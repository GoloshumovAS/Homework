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
                "Для выхода нажмите Q");

            Console.CursorVisible = false;
            int playerPositionX = 1;
            int playerPositionY = 1;
            int playerDirectionX = 0;
            int playerDirectionY = 0;

            bool isPlaying = true;

            while (isPlaying)
            {
                PlayGame(map, ref playerPositionX, playerDirectionX, ref playerPositionY, playerDirectionY, ref isPlaying);
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

        static void PlayGame(char[,] map, ref int playerPositionX, int playerDirectionX, ref int playerPositionY, int playerDirectionY, ref bool isPlaying)
        {
            CreatePlayer(ref playerPositionX, playerDirectionX, ref playerPositionY, playerDirectionY, map, ref isPlaying);
        }

        static void CreatePlayer(ref int playerPositionX, int playerDirectionX, ref int playerPositionY, int playerDirectionY, char[,] map, ref bool isPlaying)
        {
            CheckKeyboardPress(ref playerDirectionX, ref playerDirectionY, ref isPlaying);
            CanMove(ref playerPositionX, playerDirectionX, ref playerPositionY, playerDirectionY, map);
        }

        static void CheckKeyboardPress(ref int playerDirectionX, ref int playerDirectionY, ref bool isPlaying)
        {
            const char moveUp = 'W';
            const char moveDown = 'S';
            const char moveRight = 'D';
            const char moveLeft = 'A';
            const char exit = 'Q';

            if (Console.KeyAvailable)
            {

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case (ConsoleKey)moveUp:
                        playerDirectionX = 0;
                        playerDirectionY = -1;
                        break;
                    case (ConsoleKey)moveDown:
                        playerDirectionX = 0;
                        playerDirectionY = 1;
                        break;
                    case (ConsoleKey)moveLeft:
                        playerDirectionX = -1;
                        playerDirectionY = 0;
                        break;
                    case (ConsoleKey)moveRight:
                        playerDirectionX = 1;
                        playerDirectionY = 0;
                        break;
                    case (ConsoleKey)exit:
                        isPlaying = false;
                        break;
                }
            }
        }

        static void CanMove(ref int playerPositionX, int playerDirectionX, ref int playerPositionY, int playerDirectionY, char[,] map)
        {
            if (map[playerPositionX + playerDirectionX, playerPositionY + playerDirectionY] != '#')
            {
                MovePlayer(ref playerPositionX, ref playerPositionY, playerDirectionX, playerDirectionY);
            }
        }

        static void MovePlayer(ref int playerPositionX, ref int playerPositionY, int playerDirectionX, int playerDirectionY)
        {
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write(' ');

            playerPositionX += playerDirectionX;
            playerPositionY += playerDirectionY;

            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write("%");
        }
    }
}
