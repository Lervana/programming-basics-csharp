// 3.15. Napisz program, który za pomocą instrukcji do...while sumuje liczby
//       nieparzyste całkowite z przedziału podanego przez użytkownika.

Console.WriteLine("Sumowanie liczb nieparzystych w zadanym przedziale");
Console.WriteLine("-----------------------------------------------");

Console.Write("Podaj początek przedziału: ");
int poczatek = Convert.ToInt32(Console.ReadLine());

Console.Write("Podaj koniec przedziału: ");
int koniec = Convert.ToInt32(Console.ReadLine());

int suma = 0;
int liczba = poczatek;

do
{
    if (liczba % 2 != 0)
    {
        suma += liczba;
    }
    liczba++;
} while (liczba <= koniec);

Console.WriteLine($"Suma liczb nieparzystych w przedziale od {poczatek} do {koniec} wynosi: {suma}");

Console.ReadLine();