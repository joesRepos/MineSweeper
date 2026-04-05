// Set up both the hidden and visible boards.
static void InitialiseBoards(char[,] hidden, char[,] visible)
{
    for (int r = 0; r < 5; r++)
    {
        for (int c = 0; c < 5; c++)
        {
            hidden[r, c] = '.';
            visible[r, c] = '#';
        }
    }
}

// Place the mines on the inputted board.
static void PlaceMines(char[,] board, int mineCount)
{
    Random rand = new Random();
    int placed = 0;

    while (placed < mineCount)
    {
        int r = rand.Next(0, 5);
        int c = rand.Next(0, 5);

        if (board[r, c] != '*')
        {
            board[r, c] = '*';
            placed++;
        }
    }
}


// Displays the board.
static void PrintBoard(char[,] board)
{
    for (int r = 0; r < 5; r++)
    {
        for (int c = 0; c < 5; c++)
        {
            Console.Write(board[r, c] + " ");
        }
        Console.WriteLine();
    }
}

char[,] hiddenBoard = new char[5, 5];
char[,] visibleBoard = new char[5, 5];

InitialiseBoards(hiddenBoard, visibleBoard);

PlaceMines(hiddenBoard);


//Game loop.
while (true)
{
    PrintBoard(visibleBoard);

    Console.Write("Enter row (0-4): ");
    int row = int.Parse(Console.ReadLine());

    Console.Write("Enter col (0-4): ");
    int col = int.Parse(Console.ReadLine());

    // Check mine
    if (hiddenBoard[row, col] == '*')
    {
        Console.WriteLine("Mine hit!");
        break;
    }
    else
    {
        visibleBoard[row, col] = '0';
    }
}