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
            char MoveUp = 'W';
            char MoveDown = 'S';
            char MoveRight = 'D';
            char MoveLeft = 'A';
            char Exit = 'Q';

            char player = '%';
            char border = '#';
            char emptymap = ' ';

            Console.CursorVisible = true;
            Console.WriteLine("Введите размер карты по X: ");
            int mapSizeByX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер карты по Y: ");
            int mapSizeByY = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            char[,] map = CreateMap(mapSizeByX, mapSizeByY, border, emptymap);
            DrawMap(map);

            Console.SetCursorPosition(0, map.GetLength(1) + 5);
            Console.Write($"Для управления используйте клавиши {MoveUp} {MoveLeft} {MoveDown} {MoveRight}\n" +
                $"Для выхода нажмите {Exit}");

            Console.CursorVisible = false;
            int playerPositionX = 1;
            int playerPositionY = 1;
            int playerDirectionX = 0;
            int playerDirectionY = 0;

            bool isPlaying = true;

            DrawPlayer(playerPositionX, playerPositionY, player);

            while (isPlaying)
            {
                PlayGame(map, ref playerPositionX, playerDirectionX, ref playerPositionY, playerDirectionY, ref isPlaying, player, emptymap);
            }
        }

        static void DrawPlayer(int playerPositionX, int playerPositionY, char player)
        {
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write(player);
        }

        static void ClearPlayer(int playerPositionX, int playerPositionY, char emptymap)
        {
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write(emptymap);
        }

        static char[,] CreateMap(int mapSizeByX, int mapSizeByY, char border, char emptymap)
        {
            char[,] map = new char[mapSizeByX, mapSizeByY];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.SetCursorPosition(i, j);
                    map[i, j] = border;

                    if (i > 0 && i < map.GetLength(0) - 1 && j > 0 && j < map.GetLength(1) - 1)
                    {
                        map[i, j] = emptymap;
                    }
                }
            }
            return map;
        }

        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(map[i, j]);
                }
            }
        }

        static void PlayGame(char[,] map, ref int playerPositionX, int playerDirectionX, ref int playerPositionY, int playerDirectionY, ref bool isPlaying, char player, char emptymap)
        {
            CheckKeyboardPress(ref playerDirectionX, ref playerDirectionY, ref isPlaying);
            if (CanMove(playerPositionX, playerDirectionX, playerPositionY, playerDirectionY, map))
            {
                MovePlayer(ref playerPositionX, ref playerPositionY, playerDirectionX, playerDirectionY, player, emptymap);
            }
        }

        static void CheckKeyboardPress(ref int playerDirectionX, ref int playerDirectionY, ref bool isPlaying)
        {
            const char MoveUp = 'W';
            const char MoveDown = 'S';
            const char MoveRight = 'D';
            const char MoveLeft = 'A';
            const char Exit = 'Q';

            if (Console.KeyAvailable)
            {

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case (ConsoleKey)MoveUp:
                        playerDirectionX = 0;
                        playerDirectionY = -1;
                        break;
                    case (ConsoleKey)MoveDown:
                        playerDirectionX = 0;
                        playerDirectionY = 1;
                        break;
                    case (ConsoleKey)MoveLeft:
                        playerDirectionX = -1;
                        playerDirectionY = 0;
                        break;
                    case (ConsoleKey)MoveRight:
                        playerDirectionX = 1;
                        playerDirectionY = 0;
                        break;
                    case (ConsoleKey)Exit:
                        isPlaying = false;
                        break;
                }
            }
        }

        static bool CanMove(int playerPositionX, int playerDirectionX, int playerPositionY, int playerDirectionY, char[,] map)
        {
            return map[playerPositionX + playerDirectionX, playerPositionY + playerDirectionY] != '#';
        }

        static void MovePlayer(ref int playerPositionX, ref int playerPositionY, int playerDirectionX, int playerDirectionY, char player, char emptymap)
        {
            ClearPlayer(playerPositionX, playerPositionY, emptymap);

            playerPositionX += playerDirectionX;
            playerPositionY += playerDirectionY;

            DrawPlayer(playerPositionX, playerPositionY, player);
        }
    }
}
