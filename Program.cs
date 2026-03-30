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


char[,] hiddenBoard = new char[5, 5];
char[,] visibleBoard = new char[5, 5];

InitialiseBoards(hiddenBoard, visibleBoard);