// 3.16. Wiedząc, że 1233=12^2+33^2  (liczba po lewej stronie równania
//       podzielona na dwie liczby składowe, tu 12 i 33 wynosi tyle samo co te
//       liczby podniesione do potęgi i zsumowane), napisz program, który
//       znajdzie wszystkie liczby z przedziału od 1000 do 9999 spełniające tą
//       zależność, wyświetli je i poda ich liczbę.


int iloscZgodnychLiczb = 0;

for (int liczba = 1000; liczba <= 9999; liczba++)
{
    int pierwszaCzesc = liczba / 100;
    int drugaCzesc = liczba % 100;

    if (liczba == (pierwszaCzesc * pierwszaCzesc + drugaCzesc * drugaCzesc))
    {
        Console.WriteLine(liczba);
        iloscZgodnychLiczb++;
    }
}

Console.WriteLine("Ilość liczb spełniających zależność: " + iloscZgodnychLiczb);

Console.ReadLine();