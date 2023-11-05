// 3.14. Napisz program używając pętli while który policzy silnię liczby podanej
//       przez użytkownika.

Console.WriteLine("Obliczanie silnii liczby");
Console.WriteLine("------------------------");

Console.Write("Podaj liczbę: ");
int liczba = Convert.ToInt32(Console.ReadLine());

if (liczba < 0)
{
    Console.WriteLine("Silnia jest zdefiniowana tylko dla liczb nieujemnych.");
}
else
{
    int silnia = 1;
    int i = 1;

    while (i <= liczba)
    {
        silnia *= i;
        i++;
    }

    Console.WriteLine($"Silnia z {liczba} wynosi: {silnia}");
}

Console.ReadLine();