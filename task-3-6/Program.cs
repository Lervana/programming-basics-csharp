// 3.6. Napisz program, który z wykorzystaniem instrukcji wyboru switch obliczy
//      pierwiastki równania kwadratowego , gdzie zmienne a, b, c to liczby
//      rzeczywiste wprowadzone z klawiatury. Dla zmiennych a, b, c, x1 oraz
//      x2 należy przyjąć format ich wyświetlania z dokładnością do dwóch
//      miejsc po przecinku.

Console.WriteLine("Obliczanie pierwiastków równania kwadratowego");
Console.WriteLine("--------------------------------------------");

// Wprowadzenie współczynników a, b i c
Console.Write("Proszę podać współczynnik a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Proszę podać współczynnik b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Proszę podać współczynnik c: ");
double c = Convert.ToDouble(Console.ReadLine());

// Obliczenie delty (Δ)
double delta = (b * b) - (4 * a * c);

// Deklaracja zmiennych do przechowywania pierwiastków
double x1, x2;

// Instrukcja wyboru switch do obliczenia pierwiastków
switch (delta)
{
    case > 0:
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("Równanie ma dwa pierwiastki:");
        Console.WriteLine($"x1 = {x1:F2}");
        Console.WriteLine($"x2 = {x2:F2}");
        break;

    case 0:
        x1 = -b / (2 * a);
        Console.WriteLine("Równanie ma jeden pierwiastek:");
        Console.WriteLine($"x1 = {x1:F2}");
        break;

    default:
        Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
        break;
}

Console.ReadLine();
  