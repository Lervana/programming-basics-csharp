// 3.8. Napisz program wczytujący liczbę całkowitą dodatnią n i wypisujący czy
//      jest ona mniejsza lub równa 10, większa od 10 ale mniejsza lub równa
//      100, większa od 100 ale mniejsza lub równa 1000, większa od 1000.
//      Czy można użyć instrukcji switch?

// Rozwiazanie z if ... else

Console.WriteLine("Podaj liczbę całkowitą dodatnią n:");

int n = Convert.ToInt32(Console.ReadLine());

if (n <= 10) {
    Console.WriteLine("Liczba jest mniejsza lub równa 10.");
} else if (n <= 100) {
    Console.WriteLine("Liczba jest większa od 10, ale mniejsza lub równa 100.");
} else if (n <= 1000) {
    Console.WriteLine("Liczba jest większa od 100, ale mniejsza lub równa 1000.");
} else {
    Console.WriteLine("Liczba jest większa od 1000.");
}

// Rozwiązanie ze switch...case

switch (n) {
    case <= 10:
        Console.WriteLine("Liczba jest mniejsza lub równa 10.");
        break;
    case <= 100:
        Console.WriteLine("Liczba jest większa od 10, ale mniejsza lub równa 100.");
        break;
    case <= 1000:
        Console.WriteLine("Liczba jest większa od 100, ale mniejsza lub równa 1000.");
        break;
    default:
        Console.WriteLine("Liczba jest większa od 1000.");
        break;
}

Console.ReadLine();