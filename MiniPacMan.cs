using System.Runtime.CompilerServices;

Console.CursorVisible = false;

char[,] quest1 =
{
{' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
{' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' '},
{' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#','$','#',' ',' ',' ','O','#',' '},
{' ','#',' ',' ',' ',' ',' ',' ','#','#','#',' ','#','#','#','#','#',' ',' ',' ','#',' ',' ',' ',' ','#','*','#',' ','#',' ','#',' ',' ','#',' ','#',' '},
{' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ','#',' ','#',' ',' ',' ','#',' ',' ','#',' ','#',' ',' ',' ',' ','#',' '},
{' ','#',' ','#',' ',' ',' ',' ','#',' ','#',' ','#',' ','#',' ','#',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ','#',' '},
{' ','#',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#',' ','#',' ','#',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ','#',' '},
{' ','#',' ','#',' ',' ',' ',' ','#',' ','#',' ','#','$','#','0','#',' ','#',' ','#',' ','#',' ',' ','#',' ','#',' ',' ',' ',' ','#',' ','#',' ','#',' '},
{' ','#',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#','#','#','#','#',' ','#',' ',' ',' ','#',' ','#','#',' ','#',' ',' ','#',' ','#',' ','#',' ','#',' '},
{' ','#',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#','#','$','#',' ','#',' ',' ','#',' ','#',' ','#',' ','#',' '},
{' ','#',' ','#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ','#',' ','#',' ',' ',' ','#',' ',' ','#',' ','#',' '},
{' ','#',' ','#',' ',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ','#','#',' ','#',' ',' ','#',' ','#',' ','#',' ','#',' '},
{' ','#','$','#',' ',' ','*','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#','$','#',' '},
{' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' '},
{' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
};

GameAction(quest1);

void GameAction(char[,] map)
{
    char[,] newMap = new char[map.GetLength(0), map.GetLength(1)];
    Array.Copy(map, newMap, map.Length);

    int userY = 2, userX = 2;
    int bag = 0;
    bool game = true;
    
    while (game)
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                if (map[i, j] == '$')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (map[i, j] == 'O' || map[i, j] == '0')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (map[i, j] == '*')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(map[i, j]);
            }
            Console.WriteLine();
        }

        Console.SetCursorPosition(userY, userX);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("S");
        Console.SetCursorPosition(0, 14);
        Console.Write($"{bag}/5");
    
        Thread.Sleep(2);
        ConsoleKeyInfo charKey = Console.ReadKey();
        switch (charKey.Key)
        {
            case ConsoleKey.UpArrow:
                if (map[userX - 1, userY] != '#')
                {
                    userX--;
                }
                break;
    
            case ConsoleKey.DownArrow:
                if (map[userX + 1, userY] != '#')
                {
                    userX++;
                }
                break;
    
            case ConsoleKey.RightArrow:
                if (map[userX, userY + 1] != '#')
                {
                    userY++;
                }
                break;
    
            case ConsoleKey.LeftArrow:
                if (map[userX, userY - 1] != '#')
                {
                    userY--;
                }
                break;
    
            case ConsoleKey.Tab:
                Array.Copy(newMap, map, newMap.Length);
                userY = 2;
                userX = 2;
                bag = 0;
                break;
        }
    
        if (map[userX, userY] == '$')
        {
            map[userX, userY] = ' ';
            bag += 1;
    
            if (bag == 5)
                map[map.GetLength(0) - 2, map.GetLength(1) - 3] = ' ';
        }

        if (quest1[userX, userY] == '*')
        {
            quest1[userX, userY - 1] = '#';
            quest1[userX + 1, userY] = '#';
            quest1[userX - 1, userY] = '#';
            quest1[userX, userY + 1] = '#';
        }

        if (quest1[userX, userY] == 'O')
        {
            userX += 4;
            userY -= 20;
        }

        if (quest1[userX, userY] == '0')
        {
            userX -= 4;
            userY += 20;
        }

        Console.Clear();
    }
}
