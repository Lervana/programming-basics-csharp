// 3.5. Napisz program, który wyznaczy wartość funkcji kwadratowej  w zadanym
//      punkcie. Wartości współczynników a, b, c oraz punkt x mają być podane
//      przez użytkownika w trakcie działania programu. Upewnij się, żeby
//      program miał przejrzysty (w miarę możliwości) interfejs.

Console.WriteLine("Obliczanie wartości funkcji kwadratowej");
Console.WriteLine("----------------------------------------");

// Wprowadzenie współczynników a, b i c
Console.Write("Proszę podać współczynnik a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Proszę podać współczynnik b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Proszę podać współczynnik c: ");
double c = Convert.ToDouble(Console.ReadLine());

// Wprowadzenie punktu x
Console.Write("Proszę podać punkt x: ");
double x = Convert.ToDouble(Console.ReadLine());

// Obliczenie wartości funkcji kwadratowej
double wynik = (a * x * x) + (b * x) + c;

// Wyświetlenie wyniku
Console.WriteLine("Wartość funkcji kwadratowej dla x = {0} wynosi: {1}", x, wynik);

Console.ReadLine();