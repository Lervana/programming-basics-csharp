// 2.8. Napisz program, który oblicza pole prostokąta. Wartości boków a i b
//      mają być "losowe". Zmienne reprezentujące wprowadzane wartości powinny
//      być typu double. Wynik należy wyświetlić z dokładnością dwóch miejsc po
//      przecinku.

Random random = new Random();

double a = random.NextDouble() * 10;  // Losowa długość boku a (zakres 0-10)
double b = random.NextDouble() * 10;  // Losowa długość boku b (zakres 0-10)

// Oblicz pole prostokąta
double pole = a * b;

// Wyświetl wynik z dokładnością do dwóch miejsc po przecinku
// Inny przykład zaookrąglania wartości:
Console.WriteLine($"Pole prostokąta o bokach a = {a:F2} i b = {b:F2} wynosi: {pole:F2}");

Console.ReadLine();