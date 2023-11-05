//3.2.Wczytaj dwie liczby z konsoli a, b oraz sprawdź która z nich jest większa
//   (mogą być równe). Przykład:
//   > Proszę podać liczbę A: 100
//   > Proszę podać liczbę B: 90
//   > Liczba 100 jest większa od 90.

Console.Write("Proszę podać liczbę A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Proszę podać liczbę B: ");
int b = int.Parse(Console.ReadLine());

if (a > b) {
    Console.WriteLine("Liczba " + a + " jest większa od " + b + ".");
} else if (a < b) {
    Console.WriteLine("Liczba " + b + " jest większa od " + a + ".");
} else {
    Console.WriteLine("Liczby są równe.");
}

Console.ReadLine();