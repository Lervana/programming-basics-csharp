// 3.13. Napisz program, który za pomocą instrukcji for dla danych wartości
//       x zmieniających się w przedziale 0-10 obliczy wartość funkcji y = 3x.

Console.WriteLine("Obliczanie wartości funkcji y = 3x");
Console.WriteLine("----------------------------------");

// Pętla for od 0 do 10
for (int x = 0; x <= 10; x++)
{
    int y = 3 * x;
    Console.WriteLine($"Dla x = {x}, y = {y}");
}

Console.ReadLine();