// 2.4. Napisz program, który wyliczy pole prostokąta o wymiarach
//      przechowywanych w zmiennych x oraz y. Wynik ma być najpierw zapisany
//      do zmiennej z, a następnie wyświetlony.

double x = 5.0;  // Długość boku x prostokąta
double y = 3.0;  // Długość boku y prostokąta

// Oblicz pole prostokąta i zapisz wynik do zmiennej z
double z = x * y;

// Wyświetl obliczone pole prostokąta
Console.WriteLine("Pole prostokąta o wymiarach x = " + x + " i y = " + y + " wynosi: " + z);

// Tekst wyświetlany w konsoli można zapisać z użyciem interpolacji:
Console.WriteLine($"Pole prostokąta o wymiarach x = {x} i y = {y} wynosi: {z}");
