// 3.11. Zadeklaruj tablicę 5 liczb całkowitych i wypełnij ją kilkoma
//       przykładowymi danymi. Następnie oblicz średnią arytmetyczną wszystkich
//       elementów w tablicy.

int[] liczby = new int[] { 10, 20, 30, 40, 50 };

double srednia = liczby.Average();

Console.WriteLine("Tablica liczb całkowitych: " + string.Join(", ", liczby));
Console.WriteLine("Średnia arytmetyczna: " + srednia);

Console.ReadLine();