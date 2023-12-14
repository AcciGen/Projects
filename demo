//Mini PacMan
Console.CursorVisible = false;

char[,] map =
{
    {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
    {'#', '$', '#', ' ', ' ', '$', '#', ' ', ' ', ' ', ' ', '#' },
    {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '$', '#' },
    {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', '#', '#', '#' },
    {'#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
    {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
    {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
    {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
    {'#', ' ', '#', ' ', ' ', ' ', '#', '#', '#', ' ', ' ', '#' },
    {'#', ' ', '#', ' ', ' ', ' ', '#', '$', '#', ' ', ' ', '#' },
    {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', '#' },
    {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', '#' },
    {'#', ' ', ' ', '#', ' ', ' ', '#', ' ', '#', ' ', ' ', '#' },
    {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
    {'#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#' },
    {'#', ' ', ' ', ' ', ' ', '$', '#', ' ', ' ', ' ', ' ', '#' },
    {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
};

int userX = 6, userY = 6;
char[] bag = new char[1];
bool game = true;
while (game)
{
    Console.SetCursorPosition(0, 18);
    Console.Write("Bag: ");
    for (int i = 0; i < bag.Length; i++)
    {
        Console.Write(bag[i] + " ");
    }
    Console.SetCursorPosition(0, 0);
    for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int j = 0; j < map.GetLength(1); j++)
        {
            Console.Write(map[i, j]);
        }
        Console.WriteLine();
    }

    Console.SetCursorPosition(userY, userX);
    Console.Write("?");
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
    }

    if (bag.Length == 6)
    {
        Console.SetCursorPosition(0, 20);
        Console.WriteLine("You win!");
        Console.ReadKey();
        game = false;
    }

    if (map[userX, userY] == '$')
    {
        map[userX, userY] = 'X';
        char[] tempBag = new char[bag.Length + 1];
        for (int i = 0; i < bag.Length; i++)
        {
            tempBag[i] = bag[i];
        }
        tempBag[tempBag.Length - 1] = '$';
        bag = tempBag;

    }

    Console.Clear();
}
