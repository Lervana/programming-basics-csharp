// 3.7. Napisz program, który poprosi użytkownika o podanie liczby
//      (niekoniecznie całkowitej) i wypisze jej część całkowitą.

Console.WriteLine("Podaj liczbę:");

// Wczytaj liczbę od użytkownika
double liczba = Convert.ToDouble(Console.ReadLine());

// Oblicz i wyświetl część całkowitą liczby
int czescCalkowita = (int)liczba;
Console.WriteLine("Część całkowita liczby {0} wynosi: {1}", liczba, czescCalkowita);

Console.ReadLine();

