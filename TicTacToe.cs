char[,] chess = InitialzeBoard();

int player = 1;

PrintMatrix(chess);

while (true)
{
    Console.WriteLine($"Player {(player == 1 ? 'X' : 'O')} is on the move: ");
    Console.WriteLine($"Row: ");
    int row = int.Parse(Console.ReadLine());
    Console.WriteLine($"Col: ");
    int col = int.Parse(Console.ReadLine());

    if (row < 0 || row >= chess.GetLength(0) ||
        col < 0 || col >= chess.GetLength(1) ||
        chess[row, col] != '_')
    {
        Console.WriteLine("Invalid coordinates!");
        continue;
    }

    char symbol = 'X';
    if (player == -1)
    {
        symbol = 'O';
    }

    chess[row, col] = symbol;

    Console.Clear();
    PrintMatrix(chess);

    if (CheckHorizontal(chess, symbol) ||
        CheckVertical(chess, symbol) ||
        CheckDiagonals(chess, symbol))
    {
        Console.WriteLine($"Player {symbol} won the game!");
        Console.WriteLine($"Press any kay to start a new game...");
        Console.ReadKey();
        chess = InitialzeBoard();
    }

    if (IsGameOver(chess))
    {
        Console.WriteLine($"Game over!");
        Console.WriteLine($"Press any kay to start a new game...");
        Console.ReadKey();
        chess = InitialzeBoard();
    }

    player *= -1;
}

static char[,] InitialzeBoard()
{
    Console.Clear();

    return new char[,]
    {
        {'_','_','_' },
        {'_','_','_' },
        {'_','_','_' },
    };
}

static void PrintMatrix(char[,] matrix)
{
    Console.WriteLine("Tic Tac Toe: ");
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

static bool CheckHorizontal(char[,] chess, char symbol)
{
    for (int row = 0; row < chess.GetLength(0); row++)
    {
        bool isWinner = true;
        for (int col = 0; col < chess.GetLength(1); col++)
        {
            if (chess[row, col] != symbol)
            {
                isWinner = false;
                break;
            }
        }

        if (isWinner)
        {
            return true;
        }
    }
    return false;
}

static bool CheckVertical(char[,] chess, char symbol)
{
    for (int col = 0; col < chess.GetLength(1); col++)
    {
        bool isWinner = true;
        for (int row = 0; row < chess.GetLength(0); row++)
        {
            if (chess[row, col] != symbol)
            {
                isWinner = false;
                break;
            }
        }

        if (isWinner)
        {
            return true;
        }
    }
    return false;
}

static bool CheckDiagonals(char[,] chess, char symbol)
{
    bool isWinner = true;
    for (int row = 0; row < chess.GetLength(0); row++)
    {
        if (chess[row, row] != symbol)
        {
            isWinner = false;
            break;
        }
    }

    if (isWinner)
    {
        return true;
    }

    isWinner = true;
    for (int row = 0; row < chess.GetLength(0); row++)
    {
        if (chess[chess.GetLength(0) - row - 1, row] != symbol)
        {
            isWinner = false;
            break;
        }
    }
    return isWinner;
}

bool IsGameOver(char[,] chess)
{
    foreach (var item in chess)
    {
        if (item == '_')
        {
            return false;
        }
    }
    return true;
}