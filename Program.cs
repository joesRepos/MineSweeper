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

char[,] hiddenBoard = new char[5, 5];
char[,] visibleBoard = new char[5, 5];

InitialiseBoards(hiddenBoard, visibleBoard);

PlaceMines(hiddenBoard);