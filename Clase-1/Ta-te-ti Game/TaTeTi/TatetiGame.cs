namespace TaTeTi;

public class TatetiGame
{

    private char[] board;
    private char currentPlayer;
    private IConsoleInput _consoleInput;
    private IConsoleOutput _consoleOutput;
    public TatetiGame(IConsoleInput input, IConsoleOutput output)
    {
        _consoleInput = input;
        _consoleOutput = output;
        board = new char[9];
        currentPlayer = 'X';
        InitializeBoard();
    }

    public void InitializeBoard()
    {
        for (int i = 0; i < board.Length; i++)
        {
            board[i] = (i + 1).ToString()[0];
        }
    }

    public void StartGame()
    {
        _consoleOutput.WriteLine("¡Bienvenido al TA-TE-TI!");
        PrintBoard();

        while (!IsGameOver())
        {
            _consoleOutput.WriteLine($"Jugador {(currentPlayer == 'X' ? 1 : 2)}, seleccione una posición para marcar (1 - 9):");
            int position = GetInput();
            if (IsValidMove(position))
            {
                MakeMove(position);
                PrintBoard();
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            }
            else
            {
                _consoleOutput.WriteLine("Posición inválida. Intente de nuevo.");
            }
        }

        int winner = GetWinnerPlayer();
        if (winner != 0)
        {
            _consoleOutput.WriteLine($"¡El jugador {winner} ha ganado!");
        }
        else
        {
            _consoleOutput.WriteLine("¡Empate!");
        }
    }

    public void PrintBoard()
    {
        _consoleOutput.WriteLine("    |     |    ");
        _consoleOutput.WriteLine($" {board[0]}  |  {board[1]}  |  {board[2]}");
        _consoleOutput.WriteLine("    |     |    ");
        _consoleOutput.WriteLine("---------------");
        _consoleOutput.WriteLine("    |     |    ");
        _consoleOutput.WriteLine($" {board[3]}  |  {board[4]}  |  {board[5]}");
        _consoleOutput.WriteLine("    |     |    ");
        _consoleOutput.WriteLine("---------------");
        _consoleOutput.WriteLine("    |     |    ");
        _consoleOutput.WriteLine($" {board[6]}  |  {board[7]}  |  {board[8]}");
        _consoleOutput.WriteLine("    |     |    ");
        _consoleOutput.Write("\n");
    }

    public int GetInput()
    {
        string input = _consoleInput.ReadLine();
        int position;
        while (!int.TryParse(input, out position) || position < 1 || position > 9 || board[position - 1] == 'X' || board[position - 1] == 'O')
        {
            _consoleOutput.WriteLine("Entrada inválida. Intente de nuevo:");
            input = _consoleInput.ReadLine();
        }
        return position;
    }


    public bool IsValidMove(int position)
    {
        if (position < 1 || position > 9)
        {
            return false;
        }

        return board[position - 1] != 'X' && board[position - 1] != 'O';
    }

    public void MakeMove(int position)
    {
        board[position - 1] = currentPlayer;
    }

    public bool IsGameOver()
    {
        return GetWinner() != '\0' || IsBoardFull();
    }

    public bool IsBoardFull()
    {
        foreach (char c in board)
        {
            if (c != 'X' && c != 'O')
            {
                return false;
            }
        }
        return true;
    }

    public char GetWinner()
    {
        
        for (int i = 0; i < 3; i++)
        {
            if (board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2])
            {
                return board[i * 3];
            }
        }

        for (int i = 0; i < 3; i++)
        {
            if (board[i] == board[i + 3] && board[i + 3] == board[i + 6])
            {
                return board[i];
            }
        }

        if ((board[0] == board[4] && board[4] == board[8]) || (board[2] == board[4] && board[4] == board[6]))
        {
            return board[4];
        }

        return '\0';
    }

    public int GetWinnerPlayer()
    {
        char winner = GetWinner();
        if (winner == 'X')
        {
            return 1;
        }
        else if (winner == 'O')
        {
            return 2;
        }
        else
        {
            return 0; 
        }
    }

    public char[] GetBoard()
    {
        return (char[])board.Clone();
    }

}