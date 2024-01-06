//Mini PacMan
using System.Net.Http.Headers;

Console.CursorVisible = false;

char[,] quest1 =
{
{' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
{' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' ' },
{' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#','$','#',' ',' ',' ','O','#',' ' },
{' ','#',' ',' ',' ',' ',' ',' ','#','#','#',' ','#','#','#','#','#',' ',' ',' ','#',' ',' ',' ',' ','#','*','#',' ','#',' ','#',' ',' ','#',' ','#',' ' },
{' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ','#',' ','#',' ',' ',' ','#',' ',' ','#',' ','#',' ',' ',' ',' ','#',' ' },
{' ','#',' ','#',' ',' ',' ',' ','#',' ','#',' ','#',' ','#',' ','#',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ','#',' ' },
{' ','#',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#',' ','#',' ','#',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ','#',' ' },
{'-','#',' ','#',' ',' ',' ',' ','#',' ','#',' ','#','$','#','0','#',' ','#',' ','#',' ','#',' ',' ','#',' ','#',' ',' ',' ',' ','#',' ','#',' ','#','-' },
{' ','#',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#','#','#','#','#',' ','#',' ',' ',' ','#',' ','#','#',' ','#',' ',' ','#',' ','#',' ','#',' ','#',' ' },
{' ','#',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#','#','$','#',' ','#',' ',' ','#',' ','#',' ','#',' ','#',' ' },
{' ','#',' ','#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ','#',' ','#',' ',' ',' ','#',' ',' ','#',' ','#',' ' },
{' ','#',' ','#',' ',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ','#','#',' ','#',' ',' ','#',' ','#',' ','#',' ','#',' ' },
{' ','#','$','#',' ',' ','*','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#','$','#',' ' },
{' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' ' },
{' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
};
int userX = 2, userY = 3;
char[] bag = new char[1];
bool game = true;
while (game)
{
    for (int i = 0; i < bag.Length; i++)
    {
        Console.Write(bag[i] + " ");
    }

    Console.SetCursorPosition(0, 0);
    for (int i = 0; i < quest1.GetLength(0); i++)
    {
        for (int j = 0; j < quest1.GetLength(1); j++)
        {
            if (quest1[i,j] == '$' || quest1[i,j] == 'X')
            {
                Console.ForegroundColor= ConsoleColor.Yellow;
            }
            else if (quest1[i,j] == 'O' || quest1[i,j] == '0')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (quest1[i,j] == '*')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.Write(quest1[i, j]);
        }
        Console.WriteLine();
    }

    Console.SetCursorPosition(userY, userX);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("S");
    ConsoleKeyInfo charKey = Console.ReadKey();

    switch (charKey.Key)
    {
        case ConsoleKey.UpArrow:
            if (quest1[userX - 1, userY] != '#')
            {
                userX--;
            }
            break;
        case ConsoleKey.DownArrow:
            if (quest1[userX + 1, userY] != '#')
            {
                userX++;
            }
            break;
        case ConsoleKey.RightArrow:
            if (quest1[userX, userY + 1] != '#')
            {
                userY++;
            }
            break;
        case ConsoleKey.LeftArrow:
            if (quest1[userX, userY - 1] != '#')
            {
                userY--;
            }
            break;

    }

    if (bag.Length == 6)
    {
        Console.SetCursorPosition(0, 20);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You win!");
        Console.ReadKey();
        game = false;
    }

    if (quest1[userX, userY] == '$')
    {
        quest1[userX, userY] = 'X';
        char[] tempBag = new char[bag.Length + 1];
        for (int i = 0; i < bag.Length; i++)
        {
            tempBag[i] = bag[i];
        }
        tempBag[tempBag.Length - 1] = '$';
        bag = tempBag;

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
