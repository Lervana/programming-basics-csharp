// 3.19. Napisz prostą grę konsolową pozwalająca na rozegranie partii gry
//       "Kółko i krzyżyk" na 9 kratek (3x3).  Program na starcie powinien
//       umożliwiać podanie nazw graczy. Gra ma polegać na następujących
//       sekwencjach:
//       - Zacznij od przygotowania i rozrysowania algorytmu!
//       - Wyświetlenie widoku tabelki;
//       - Zapytanie użytkownika A o koordynaty (np. może on wpisać wartość 22 co oznacza środek planszy);
//       - Wyświetlenie widoku tabelki;
//       - Sprawdzenie wygranej;
//       - Zapytanie użytkownika B o koordynaty;
//       - Sprawdzenie wygranej;
//       - W przypadku wygranej wyświetlenie komunikatu i nazwy zwycięzcy;

char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
bool isPlayerX = true;
string playerX;
string playerO;
int moves = 0;

Console.WriteLine("Witaj w grze Kółko i krzyżyk!");
Console.Write("Podaj nazwę gracza X: ");
playerX = Console.ReadLine();
Console.Write("Podaj nazwę gracza O: ");
playerO = Console.ReadLine();

while (true)
{
    Console.Clear();
    Console.WriteLine("   |   |   ");
    Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
    Console.WriteLine("___|___|___");
    Console.WriteLine("   |   |   ");
    Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
    Console.WriteLine("___|___|___");
    Console.WriteLine("   |   |   ");
    Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    Console.WriteLine("   |   |   ");

    int choice;

    while (true)
    {
        Console.WriteLine("Ruch gracza " + (isPlayerX ? playerX : playerO));
        Console.Write("Wybierz pole (1-9): ");
        if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O')
            break;
        else
            Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
    }

    if (isPlayerX)
        board[choice - 1] = 'X';
    else
        board[choice - 1] = 'O';

    moves++;

    if ((board[0] == board[1] && board[1] == board[2]) ||  // Pierwszy rząd
        (board[3] == board[4] && board[4] == board[5]) ||  // Drugi rząd
        (board[6] == board[7] && board[7] == board[8]) ||  // Trzeci rząd
        (board[0] == board[3] && board[3] == board[6]) ||  // Pierwsza kolumna
        (board[1] == board[4] && board[4] == board[7]) ||  // Druga kolumna
        (board[2] == board[5] && board[5] == board[8]) ||  // Trzecia kolumna
        (board[0] == board[4] && board[4] == board[8]) ||  // Przekątna 1
        (board[2] == board[4] && board[4] == board[6]))    // Przekątna 2
    {
        Console.Clear();
        Console.WriteLine("   |   |   ");
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        Console.WriteLine("   |   |   ");
        Console.WriteLine("Gratulacje! Wygrał(a): " + (isPlayerX ? playerX : playerO));
        break;
    }
    else if (moves == 9)
    {
        Console.Clear();
        Console.WriteLine("   |   |   ");
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        Console.WriteLine("   |   |   ");
        Console.WriteLine("Remis! Plansza jest pełna.");
        break;
    }
    else
    {
        isPlayerX = !isPlayerX;
    }
}