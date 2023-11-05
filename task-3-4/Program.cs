// 3.4. Napisz prosty kalkulator pozwalający na proste operacje na wartościach
//      typu double. Program ma umożliwiać operacje takie jak suma, różnica,
//      iloczyn oraz iloraz. Operacja powinna być wybierana z klawiatury -
//      wpisanie odpowiedniego znaku (+, -, /, *) definiuje jaką operacje ma
//      wykonać program. Przykład:
//      > Proszę podać wartość A: 10
//      > Proszę podać wartość B: 5
//      > Proszę podać operator [+, -, *, /]: +
//      > Wynik: 10 + 5 = 15


Console.WriteLine("Prosty kalkulator");
Console.WriteLine("------------------");

// Wprowadzenie dwóch liczb
Console.Write("Proszę podać wartość A: ");
double liczbaA = Convert.ToDouble(Console.ReadLine());

Console.Write("Proszę podać wartość B: ");
double liczbaB = Convert.ToDouble(Console.ReadLine());

// Wybór operatora
Console.Write("Proszę podać operator [+, -, *, /]: ");
char operacja = Convert.ToChar(Console.ReadLine());

// Obliczenie wyniku na podstawie operatora
double wynik = 0;
switch (operacja)
{
    case '+':
        wynik = liczbaA + liczbaB;
        break;
    case '-':
        wynik = liczbaA - liczbaB;
        break;
    case '*':
        wynik = liczbaA * liczbaB;
        break;
    case '/':
        if (liczbaB != 0)
        {
            wynik = liczbaA / liczbaB;
        }
        else
        {
            Console.WriteLine("Błąd: Nie można dzielić przez zero.");
            return;
        }
        break;
    default:
        Console.WriteLine("Błąd: Nieznany operator.");
        return;
}

// Wyświetlenie wyniku
Console.WriteLine("Wynik: {0} {1} {2} = {3}", liczbaA, operacja, liczbaB, wynik);

Console.ReadLine();
