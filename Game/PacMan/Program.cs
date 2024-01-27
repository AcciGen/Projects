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

char[,] quest2 =
{
{' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#',' '},
{' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' ','#',' '},
{' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' '},
{' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' '},
{' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' '},
{' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' '},
{' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' '},
{' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' '},
{' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' '},
{' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' '},
{' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' '},
{' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' '},
{' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' '},
{' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' '},
{' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
};



EasyLevel(quest1);
MediumLevel(quest2);

#region
void EasyLevel(char[,] map, int userY = 2, int userX = 2)
{
    char[,] newMap = new char[map.GetLength(0), map.GetLength(1)];
    Array.Copy(map, newMap, map.Length);
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
        Console.Write('S');
        Console.SetCursorPosition(0, 14);
        Console.Write($"{bag}/5");

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

            case ConsoleKey.Enter:
                bag = 4;
                break;
        }

        if (map[userX, userY] == '$')
        {
            map[userX, userY] = ' ';
            bag += 1;

            if (bag > 4)
                map[map.GetLength(0) - 2, map.GetLength(1) - 3] = ' ';
        }

        if (map[userX, userY] == '*')
        {
            map[userX, userY - 1] = '#';
            map[userX + 1, userY] = '#';
            map[userX - 1, userY] = '#';
            map[userX, userY + 1] = '#';
        }

        if (map[userX, userY] == 'O')
        {
            userX += 4;
            userY -= 20;
        }

        if (map[userX, userY] == '0')
        {
            userX -= 4;
            userY += 20;
        }

        if (userX == map.GetLength(0) - 2 && userY == map.GetLength(1) - 3)
        {
            game = false;
        }

        Console.Clear();
    }
}
#endregion
#region
void MediumLevel(char[,] map)
{
    char[,] newMap = new char[map.GetLength(0), map.GetLength(1)];
    Array.Copy(map, newMap, map.Length);

    int userY = 35, userX = 0;
    int bag = 0;
    bool game = true;
    Console.ForegroundColor = ConsoleColor.Magenta;
    var color = ConsoleColor.Magenta;

    while (game)
    {
        Console.SetCursorPosition(0, 0);
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                if (map[i, j] == '$')
                {
                    color = ConsoleColor.Yellow;
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
                    Console.ForegroundColor = color;
                }
                Console.Write(map[i, j]);
            }
            Console.WriteLine();
        }

        Console.SetCursorPosition(userY, userX);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("W");
        Console.SetCursorPosition(0, 14);
        Console.Write($"{bag}/5");

        int attackActivation = DateTime.Now.Second;

        ConsoleKeyInfo charKey = Console.ReadKey();
        if (color == ConsoleColor.Red && attackActivation + 1 > DateTime.Now.Second)
        {
            Array.Copy(newMap, map, newMap.Length);
            userY = 35;
            userX = 0;
            bag = 0;
        }
        switch (charKey.Key)
        {
            case ConsoleKey.UpArrow:
                if (userY == 35 && userX == 0)
                {
                    Console.Clear();
                    EasyLevel(quest1, quest1.GetLength(1) - 3, quest1.GetLength(0) - 3);
                }
                else if (map[userX - 1, userY] != '#')
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
                userY = 35;
                userX = 0;
                bag = 0;
                break;
        }
        Console.SetCursorPosition(0, 18);
        Console.WriteLine(attackActivation);
        Console.WriteLine(DateTime.Now.Second.ToString());
        if (attackActivation + 1 < DateTime.Now.Second)
        {
            if (color == ConsoleColor.Magenta)
            {
                color = ConsoleColor.Red;
            }
            else
            {
                color = ConsoleColor.Magenta;
            }
        }

        if (map[userX, userY] == '$')
        {
            map[userX, userY] = ' ';
            bag += 1;

            if (bag > 4)
                map[map.GetLength(0) - 2, map.GetLength(1) - 3] = ' ';
        }

    }
}
#endregion