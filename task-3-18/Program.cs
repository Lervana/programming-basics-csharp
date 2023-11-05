// 3.18. Napisz program wypisujący na ekranie prostokąt złożony z gwiazdek,
//       wymiaru m x n. Wartości m, n podane przez użytkownika. Zmodyfikuj
//       program by wypisywał kwadrat n x n.

Console.WriteLine("Program rysujący prostokąt");
Console.WriteLine("Podaj szerokość (n): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj wysokość (m): ");
int m = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.ReadLine();