// 3.9. Zadeklaruj tablicę liczb całkowitych i wypełnij ją kilkoma
//      przykładowymi danymi. Następnie wyświetl jej zawartość na konsoli.

// Deklaracja i inicjalizacja tablicy liczb całkowitych
int[] liczby = new int[] { 10, 20, 30, 40, 50 };
string tekst = string.Join(", ", liczby);

// Wyświetlenie zawartości tablicy na konsoli
Console.WriteLine("Zawartość tablicy:");
Console.WriteLine(tekst);

Console.ReadLine();