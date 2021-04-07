using System;

namespace Net5.Fundamentals.Evidence.Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            char[,] board = new char[3, 3];
            string player1 = "", player2 = "", playerName = "";
            bool playerTurn1 = true;

            Console.WriteLine("  ** tic - tac - toe **");
            Console.WriteLine("  =====================");
            Console.WriteLine();
            InitializeBoard(ref board);
            Console.WriteLine(Board(board));
            Console.WriteLine();

            while (player1 == "")
            {
                Console.WriteLine("Ingrese alias jugador 1 - Jugaras con la X: ");
                player1 = Console.ReadLine();
                Console.WriteLine();
            }

            while (player2 == "")
            {
                Console.WriteLine("Ingrese alias jugador 2 - Jugaras con la O: ");
                player2 = Console.ReadLine();
                Console.WriteLine();
            }

            while (!Winner(board))
            {
                Console.Clear();
                Console.WriteLine("  ** Tic - Tac - Toe **");
                Console.WriteLine("  =====================");
                Console.WriteLine();
                Console.WriteLine(Board(board));
                Console.WriteLine();

                if (playerTurn1) { playerName = player1; }
                else { playerName = player2; }

                count++;
                string coordinate = "";
                while (!ValidateCoordinate(coordinate) || BoxOccupied(board, coordinate))
                {
                    if (count == 1)
                    {
                        Console.WriteLine($"{playerName}, introduce coordenada donde quieres jugar");
                        Console.WriteLine("Por ejemplo, A1");
                    }
                    else Console.WriteLine($"{playerName}, introduce coordenada donde quieres jugar");

                    coordinate = Console.ReadLine().ToUpper();

                    if (!ValidateCoordinate(coordinate))
                    {
                        Console.WriteLine();
                        Console.WriteLine("La coordenada no es válida");
                        Console.WriteLine("");
                    }

                    if (BoxOccupied(board, coordinate))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("La coordenda ingresada esta ocupada, ingrese otra");
                        Console.WriteLine("");
                    }
                }                

                char usedCharacter = ' ';
                if (playerTurn1) usedCharacter = 'X';
                else usedCharacter = 'O';

                AddCoordinates(ref board, coordinate, usedCharacter);

                if (Winner(board))
                {
                    break;
                }

                if (BoardComplete(ref board))
                {
                    Console.Clear();
                    Console.WriteLine("  ** Tic - Tac - Toe **");
                    Console.WriteLine("  =====================");
                    Console.WriteLine();
                    Console.WriteLine(Board(board));
                    Console.WriteLine();
                    Console.WriteLine("Fin del juego");
                    Console.WriteLine("Empate. Noha ganado nadie");
                }

                playerTurn1 = !playerTurn1;
            }

            if (Winner(board))
            {
                Console.Clear();
                Console.WriteLine("  ** Tic - Tac - Toe **");
                Console.WriteLine("  =====================");
                Console.WriteLine();
                Console.WriteLine(Board(board));
                Console.WriteLine();

                Console.WriteLine("Fin del juego");
                if (Victory(board) == 'X')
                {
                    Console.WriteLine($"{player1} ha ganado esta partida.");
                }
                else
                {
                    Console.WriteLine($"{player2} ha ganado esta partida.");
                }

            }

            Console.ReadKey();

            static void InitializeBoard(ref char[,] board)
            {
                for (int i = 0; i < 3; i++)
                     for (int j = 0; j < 3; j++)
                          board[i, j] = ' ';
            }

            static string Board(char[,] board)
            {
                string tablero = "";
                tablero = "       1     2     3  " + Environment.NewLine; ;
                tablero += "          ┬     ┬     " + Environment.NewLine;
                tablero += $"  A    {board[0, 0]}  │  {board[0, 1]}  │  {board[0, 2]}  " + Environment.NewLine;
                tablero += "     ─────┼─────┼─────" + Environment.NewLine;
                tablero += $"  B    {board[1, 0]}  │  {board[1, 1]}  │  {board[1, 2]}  " + Environment.NewLine;
                tablero += "     ─────┼─────┼─────" + Environment.NewLine;
                tablero += $"  C    {board[2, 0]}  │  {board[2, 1]}  │  {board[2, 2]}  " + Environment.NewLine;
                tablero += "          ┴     ┴     " + Environment.NewLine;

                return tablero;
            }

            static char Victory(char[,] board)
            {
                if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] != ' ') return board[0, 0];
                if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] != ' ') return board[1, 0];
                if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] != ' ') return board[2, 0];
                if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] != ' ') return board[0, 0];
                if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] != ' ') return board[0, 1];
                if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] != ' ') return board[0, 2];
                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ') return board[0, 0];
                if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ') return board[0, 2];
                return ' ';
            }

            static bool Winner(char[,] board)
            {
                return Victory(board) != ' ';
            }

            static bool Occupied(char[,] board, int x, int y)
            {
                if (x < 0 || x > 2) { throw new ArgumentException("el valor de x debe ser 0, 1 o 2", "x"); }
                if (y < 0 || y > 2) { throw new ArgumentException("el valor de y debe ser 0, 1 o 2", "y"); }
                return board[x, y] != ' ';
            }

            static bool BoxOccupied(char[,] board, string coordinate)
            {
                coordinate = coordinate.ToUpper();

                switch (coordinate)
                {
                    case "A1": return Occupied(board, 0, 0);
                    case "A2": return Occupied(board, 0, 1);
                    case "A3": return Occupied(board, 0, 2);
                    case "B1": return Occupied(board, 1, 0);
                    case "B2": return Occupied(board, 1, 1);
                    case "B3": return Occupied(board, 1, 2);
                    case "C1": return Occupied(board, 2, 0);
                    case "C2": return Occupied(board, 2, 1);
                    case "C3": return Occupied(board, 2, 2);
                }
                return false;
            }

            static void AddCoordinates(ref char[,] board, string coordinate, char letra)
            {
                coordinate = coordinate.ToUpper();

                switch (coordinate)
                {
                    case "A1":
                        board[0, 0] = letra;
                        return;
                    case "A2":
                        board[0, 1] = letra;
                        return;
                    case "A3":
                        board[0, 2] = letra;
                        return;
                    case "B1":
                        board[1, 0] = letra;
                        return;
                    case "B2":
                        board[1, 1] = letra;
                        return;
                    case "B3":
                        board[1, 2] = letra;
                        return;
                    case "C1":
                        board[2, 0] = letra;
                        return;
                    case "C2":
                        board[2, 1] = letra;
                        return;
                    case "C3":
                        board[2, 2] = letra;
                        return;
                }
            }

            static bool ValidateCoordinate(string coordinate)
            {
                switch (coordinate)
                {
                    case "A1":
                    case "A2":
                    case "A3":
                    case "B1":
                    case "B2":
                    case "B3":
                    case "C1":
                    case "C2":
                    case "C3":
                        return true;
                    default:
                        return false;
                }
            }

            static bool BoardComplete(ref char[,] board)
            {
                if(board[0,0] != ' ' && board[0,1] != ' ' && board[0,2] != ' ' &&
                   board[1, 0] != ' ' && board[1, 1] != ' ' && board[1, 2] != ' ' &&
                   board[2, 0] != ' ' && board[2, 1] != ' ' && board[2, 2] != ' ')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
