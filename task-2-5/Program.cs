// 2.5. Napisz program, który przeliczy wartość z PLN na USD oraz EURO.
//      Na razie nie wczytuj wartości od użytkownika, tylko wprowadź
//      ją bezpośrednio w kodzie.

double wartoscPLN = 100.0;  // Wartość w polskich złotych (PLN)
double kursUSD = 3.85;      // Kurs wymiany PLN na USD
double kursEURO = 4.3;      // Kurs wymiany PLN na EURO

// Przelicz na USD i EURO
double wartoscUSD = wartoscPLN / kursUSD;
double wartoscEURO = wartoscPLN / kursEURO;

// Wyświetl wynik
Console.WriteLine(wartoscPLN + " PLN to " + wartoscUSD + " USD");
Console.WriteLine(wartoscPLN + " PLN to " + wartoscEURO + " EURO");

// Powyższe wartości warto zaookrąglić do 2 miejsc po przecinku:
Console.WriteLine();
Console.WriteLine(wartoscPLN + " PLN to " + Math.Round(wartoscUSD, 2) + " USD");
Console.WriteLine(wartoscPLN + " PLN to " + Math.Round(wartoscEURO, 2) + " EURO");
