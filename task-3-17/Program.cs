// 3.17. Narysuj w konsoli wypełniony prostokąt z gwiazdek o szerokości 5
//       i wysokości 3.

int szerokosc = 5;
int wysokosc = 3;

for (int i = 0; i < wysokosc; i++)
{
    for (int j = 0; j < szerokosc; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.ReadLine();