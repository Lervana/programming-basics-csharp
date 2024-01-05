// 4.16. Zaprojektuj i zaimplementuj prostą grę konsolową "Wisielec" w języku
//       C#, demonstrując podstawowe umiejętności programowania, w tym obsługę
//       wejścia/wyjścia, pętle, instrukcje warunkowe oraz podstawy zarządzania
//       danymi.
//
//       [https://pl.wikipedia.org/wiki/Wisielec_(gra)]
//
//       Wymagania Ogólne:
//       - Gra powinna posiadać prosty interfejs tekstowy, który umożliwia interakcję z użytkownikiem.
//       - Gra automatycznie wybiera słowo z predefiniowanej listy.
//       - Lista słów powinna być zaimplementowana jako tablica lub lista w kodzie.
//       - Użytkownik próbuje odgadnąć litery słowa.
//       - Po każdej próbie, gra aktualizuje stan słowa, pokazując odgadnięte litery.
//       - Nieodgadnięte litery powinny być reprezentowane jako myślniki.
//       - Użytkownik ma ograniczoną liczbę prób na odgadnięcie całego słowa (np. 6 prób).
//       - Ilość pozostałych prób powinna wyświetlać się jako np. liczba żyć.
//       - Gra kończy się, gdy użytkownik odgadnie słowo lub skończą się próby.
//       - Gra wyświetla odpowiednie komunikaty o wygranej lub przegranej.
//       - Po zakończeniu gry, użytkownik powinien mieć możliwość rozpoczęcia nowej gry.
//       - Wyświetlona powinna być punktacja Użytkownik / Komputer zliczająca wszystkie rozgrywki.
//       - Punktację zapisz do pliku tak by była zachowana pomiędzy uruchomieniami aplikacji.
//       - Gra powinna odpowiednio radzić sobie z nieprawidłowymi wejściami od użytkownika.
//       - Kod powinien być dobrze zorganizowany, czytelny i odpowiednio skomentowany.
//       - Zwróć uwagę na efektywność kodu, szczególnie w obsłudze łańcuchów znaków.

// THIS IS ONLY EXAMPLE, REMEMBER TO ADD PROPER VALIDATION!


class Game
{
    private static string[] words = { "programming", "hangman", "computer", "code", "game" };
    private static string wordToGuess;
    private static char[] guessedLetters;
    private static int attemptsLeft;
    private static int userScore;
    private static int computerScore;

    private static void InitializeGame()
    {
        Random random = new Random();
        wordToGuess = words[random.Next(words.Length)];
        guessedLetters = new char[wordToGuess.Length];
        attemptsLeft = 6;
        Array.Fill(guessedLetters, '-');
    }

    private static void DisplayGameStatus()
    {
        Console.WriteLine($"Word: {string.Join(" ", guessedLetters)}");
        Console.WriteLine($"Attempts left: {attemptsLeft}");
        Console.WriteLine($"Your Score: {userScore} | Computer Score: {computerScore}");
    }

    private static void UpdateGuessedLetters(char guess)
    {
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            if (wordToGuess[i] == guess)
            {
                guessedLetters[i] = guess;
            }
        }
    }

    private static void PlayGame()
    {
        while (attemptsLeft > 0 && Array.IndexOf(guessedLetters, '-') != -1)
        {
            Console.Write("Enter a letter: ");
            char input = Console.ReadLine().ToLower().FirstOrDefault();

            if (!char.IsLetter(input))
            {
                Console.WriteLine("Invalid input. Please enter a valid letter.");
                continue;
            }

            if (Array.IndexOf(guessedLetters, input) != -1)
            {
                Console.WriteLine("You've already guessed that letter.");
                continue;
            }

            if (wordToGuess.Contains(input))
            {
                UpdateGuessedLetters(input);
            }
            else
            {
                attemptsLeft--;
            }

            DisplayGameStatus();
        }

        if (attemptsLeft == 0)
        {
            Console.WriteLine("You lose! The word was: " + wordToGuess);
            computerScore++;
        }
        else
        {
            Console.WriteLine("Congratulations! You guessed the word: " + wordToGuess);
            userScore++;
        }
    }

    private static void SaveScoresToFile()
    {
        using (StreamWriter writer = new StreamWriter("scores.txt"))
        {
            writer.WriteLine($"User Score: {userScore}");
            writer.WriteLine($"Computer Score: {computerScore}");
        }
    }

    public static void Main(string[] args)
    {
        bool playAgain = true;

        string TASK_TRANSLATION = "4.16. Design and implement the simple console " +
             "game in C#, demonstrating basic programming skills including I/O, " +
             "loops, conditionals, and basic data management." +
             "\n\n[https://pl.wikipedia.org/wiki/Wisielec_(gra)]\n\n" +
             "General requirements:\n" +
             "- The game should have a simple text interface that allows interaction with the user.\n" +
             "- The game automatically selects a word from a predefined list.\n" +
             "- The word list should be implemented as an array or list in your code.\n" +
             "- The user tries to guess the letters of the word.\n" +
             "- After each attempt, the game updates the word status, showing the guessed letters.\n" +
             "- Unguessed letters should be represented as dashes.\n" +
             "- The user has a limited number of attempts to guess the entire word (e.g. 6 tries).\n" +
             "- The number of remaining attempts should be displayed as, for example, the number of lives.\n" +
             "- The game ends when the user guesses the word or the attempts run out.\n" +
             "- The game displays appropriate messages about winning or losing.\n" +
             "- Once the game is finished, the user should be able to start a new game.\n" +
             "- The User/Computer score should be displayed, counting all games.\n" +
             "- Save the score to a file so that it is retained between application runs.\n" +
             "- The game should properly handle invalid input from the user.\n" +
             "- The code should be well organized, readable and appropriately commented.\n" +
             "- Pay attention to the efficiency of your code, especially in handling strings.";

        string LINE = new string('-', Console.WindowWidth);

        Console.WriteLine(LINE);
        Console.WriteLine(TASK_TRANSLATION);
        Console.WriteLine(LINE);

        Console.WriteLine();
        
        while (playAgain)
        {
            InitializeGame();
            DisplayGameStatus();
            PlayGame();
            SaveScoresToFile();


            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "yes";
        }

        Console.WriteLine();
        Console.WriteLine(LINE);
    }
}
