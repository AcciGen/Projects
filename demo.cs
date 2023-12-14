Console.CursorVisible = false;

char[,] map =
{
    {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' , '#', '#','#','#'},
    {'#', '$', '#', ' ', ' ', '$', '#', ' ', ' ', ' ', ' ', '#' , '$','#', '*', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '$', '#' , ' ','#', ' ', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', '#', '#', '#' , ' ','#', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' , ' ','#', ' ', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' , ' ','#', '*', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' , '#','#', ' ', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' , ' ','#', ' ', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', '#', '#', '#', ' ', ' ', '#' , ' ','#', ' ', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', '#', '$', '#', ' ', ' ', '#' , ' ','#', '*', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', '#' , ' ','#', ' ', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', '#' , ' ','#', ' ', '#'},
    {'#', ' ', ' ', '#', ' ', ' ', '#', ' ', '#', ' ', ' ', '#' , ' ','#', ' ', '#'},
    {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#' , ' ','#', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#' , ' ',' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', '$', '#', ' ', ' ', ' ', ' ', '#' , ' ',' ', ' ', '#'},
    {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' , '#','#', '#', '#'}
};

int userX = 6, userY = 6;
char[] bag = new char[1];
bool game = true;
int jj = 0;
while (game)
{
    Console.SetCursorPosition(0, 18);
    Console.Write("Bag: ");
    {

    }
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
            if (map[userX - 1, userY] != '#' && map[userX - 1, userY] != '_')
            {
                userX--;
            }
            break;
        case ConsoleKey.DownArrow:
            if (map[userX + 1, userY] != '#' && map[userX + 1, userY] != '_')
            {
                userX++;

            }
            break;
        case ConsoleKey.RightArrow:
            if (map[userX, userY + 1] != '#' && map[userX, userY + 1] != '_')
            {
                userY++;

            }
            break;
        case ConsoleKey.LeftArrow:
            if (map[userX, userY - 1] != '#' && map[userX, userY - 1] != '_')
            {
                userY--;
            }
            break;
    }

    if (bag.Length == 9 && jj == 2)
    {
        Console.SetCursorPosition(0, 20);
        Console.WriteLine("You win!");
        Console.ReadKey();
        Console.ReadKey();
        game = false;
    }

    if (map[userX, userY] == '$')
    {
        map[userX, userY] = 'X';
        Console.Beep(269, 400);
        char[] tempBag = new char[bag.Length + 1];
        for (int i = 0; i < bag.Length; i++)
        {
            tempBag[i] = bag[i];
        }
        tempBag[tempBag.Length - 1] = '$';
        bag = tempBag;

    }
    if (map[userX, userY] == '*')
    {
        map[userX, userY] = ' ';
        Console.Beep(269, 400);
        jj += 1;
        if (jj == 2)
            map[6, 12] = ' ';
        if (jj == 3)
        {
            map[6, 12] = '_';
        }

        char[] tempBag = new char[bag.Length + 1];
        for (int i = 0; i < bag.Length; i++)
        {
            tempBag[i] = bag[i];
        }
        tempBag[tempBag.Length - 1] = '*';
        bag = tempBag;

    }

    Console.Clear();
}
