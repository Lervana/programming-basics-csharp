// 2.3. Zdefiniuj i zainicjuj dwie zmienne, pierwsza ma być wartością całkowitą,
//      druga stałą z wartością „X”. Następnie wyświetl je w dwóch liniach.
//      Teraz do pierwszej zmiennej przypisz inną wartość i wyświetl ją.
//      Czy do zmiennej stałej można przypisać nową wartość?

int value = 10;  // Definicja i inicjalizacja zmiennej całkowitoliczbowej
const int value2 = 100;  // Definicja i inicjalizacja stałej całkowitoliczbowej

Console.WriteLine("Wartość zmiennej całkowitoliczbowej: " + value);
Console.WriteLine("Wartość stałej całkowitoliczbowej: " + value2);

value = 20;  // Przypisanie nowej wartości zmiennej całkowitoliczbowej
Console.WriteLine("Nowa wartość zmiennej całkowitoliczbowej: " + value);

// Próba przypisania nowej wartości do stałej spowoduje błąd kompilacji:
// value2 = 200;  // To spowoduje błąd kompilacji

Console.ReadLine();