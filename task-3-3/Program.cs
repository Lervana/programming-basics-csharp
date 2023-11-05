// 3.3. Zmodyfikuj program z listy nr 2 zadanie 5 tak by wartość wraz z walutą
//      była wczytywana z konsoli. Użyj instrukcji switch … case. Przykład:
//      > Proszę podać wartość: 100
//      > Proszę podać walutę wejściową [PLN, USD, EUR]: USD
//      > Proszę podać walutę docelową [PLN, USD, EUR]: PLN
//      > 100USD = 450PLN

Console.Write("Proszę podać wartość: ");
double wartosc = double.Parse(Console.ReadLine());

Console.Write("Proszę podać walutę wejściową [PLN, USD, EUR]: ");
string walutaWejsciowa = Console.ReadLine();

Console.Write("Proszę podać walutę docelową [PLN, USD, EUR]: ");
string walutaDocelowa = Console.ReadLine();

double przeliczonaWartosc = 0;

switch(walutaWejsciowa + "_" + walutaDocelowa)
{
    case "PLN_PLN": przeliczonaWartosc = wartosc; break;
    case "PLN_USD": przeliczonaWartosc = wartosc / 4.15; break;
    case "PLN_EUR": przeliczonaWartosc = wartosc / 4.5; break;
    case "USD_PLN": przeliczonaWartosc = wartosc * 4.15; break;
    case "USD_USD": przeliczonaWartosc = wartosc; break;
    case "USD_EUR": przeliczonaWartosc = wartosc * 0.9; break;
    case "EUR_PLN": przeliczonaWartosc = wartosc * 4.5; break;
    case "EUR_USD": przeliczonaWartosc = wartosc * 1.1; break;
    case "EUR_EUR": przeliczonaWartosc = wartosc; break;
}

double wynik = Math.Round(przeliczonaWartosc, 2);

Console.WriteLine($"{wartosc}{walutaWejsciowa} = {wynik}{walutaDocelowa}");

Console.ReadLine();