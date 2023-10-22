// 2.7. Zmodyfikuj program z zadania 6 tak by wartości tych zmiennych była
//      "losowa".

Random random = new Random();

double liczbaA = random.NextDouble() * 100;  // Losowa liczba A z zakresu 0 do 100
double liczbaB = random.NextDouble() * 100;  // Losowa liczba B z zakresu 0 do 100

if (liczbaA > liczbaB) {
    Console.WriteLine($"Liczba A ({liczbaA}) jest większa od liczby B ({liczbaB}).");
}
else if (liczbaA < liczbaB) {
    Console.WriteLine($"Liczba A ({liczbaA}) jest mniejsza od liczby B ({liczbaB}).");
}
else {
    Console.WriteLine($"Liczba A ({liczbaA}) jest równa liczbie B ({liczbaB}).");
}