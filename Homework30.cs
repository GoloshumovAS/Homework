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

            CreatePlayer(playerPositionX, playerPositionY);

            while (isPlaying)
            {
                PlayGame(map, ref playerPositionX, playerDirectionX, ref playerPositionY, playerDirectionY, ref isPlaying);
            }
        }

        static void CreatePlayer(int playerPositionX, int playerPositionY)
        {
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write('%');
        }

        static char[,] CreateMap(int mapSizeByX, int mapSizeByY)
        {
            char[,] map = new char[mapSizeByX, mapSizeByY];

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
            CheckKeyboardPress(ref playerDirectionX, ref playerDirectionY, ref isPlaying);
            CheckAbilityMove(ref playerPositionX, playerDirectionX, ref playerPositionY, playerDirectionY, map);
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

        static void CheckAbilityMove(ref int playerPositionX, int playerDirectionX, ref int playerPositionY, int playerDirectionY, char[,] map)
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
