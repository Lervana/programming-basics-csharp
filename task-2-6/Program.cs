// 2.6. Stwórz dwie zmienne zawierające wartość liczbową i sprawdź która
//      z nich jest większa (mogą być równe).

double liczbaA = 10.5;
double liczbaB = 7.2;

if (liczbaA > liczbaB) {
    Console.WriteLine($"Liczba A ({liczbaA}) jest większa od liczby B ({liczbaB}).");
}
else if (liczbaA < liczbaB) {
    Console.WriteLine($"Liczba A ({liczbaA}) jest mniejsza od liczby B ({liczbaB}).");
}
else {
    Console.WriteLine($"Liczba A ({liczbaA}) jest równa liczbie B ({liczbaB}).");
}