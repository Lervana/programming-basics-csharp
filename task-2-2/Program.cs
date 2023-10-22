// 2.2. Zdefiniuj i zainicjuj po jednej zmiennej typu całkowitego,
//      zmiennoprzecinkowego, logicznego i znakowego. Jakie zmienne można ze
//      sobą dodać i jaki będzie tego efekt?

int liczbaCalkowita = 5;                  // Zmienna całkowita
float liczbaZmiennoprzecinkowa = 3.14f;   // Zmienna zmiennoprzecinkowa (z 'f' na końcu)
double liczbaZmiennoprzecinkowa2 = 3.14;  // Zmienna zmiennoprzecinkowa typu double
bool wartoscLogiczna = true;              // Zmienna logiczna
char znak = 'a';                          // Zmienna znakowa

var wynik1 = liczbaCalkowita + liczbaCalkowita; // 5 + 5 = 10
Console.WriteLine($"{liczbaCalkowita} + {liczbaCalkowita} = {wynik1}");

var wynik2 = liczbaCalkowita + liczbaZmiennoprzecinkowa; // 5 + 3.14 = 8.14
Console.WriteLine($"{liczbaCalkowita} + {liczbaZmiennoprzecinkowa} = {wynik2}");

var wynik3 = liczbaCalkowita + liczbaZmiennoprzecinkowa2; // 5 + 3.14 = 8.14
Console.WriteLine($"{liczbaCalkowita} + {liczbaZmiennoprzecinkowa2} = {wynik3}");

// var wynik4 = liczbaCalkowita + wartoscLogiczna;
// Powyższa linia daje błąd:
// Error CS0019: Operator '+' cannot be applied to operands of type 'int' and 'bool' (CS0019)

var wynik5 = liczbaCalkowita + znak; // 5 + a = 102 // Dlaczego?
Console.WriteLine($"{liczbaCalkowita} + {znak} = {wynik5}");

var wynik6 = liczbaZmiennoprzecinkowa + liczbaZmiennoprzecinkowa; // 3.14 + 3.14 = 6.28
Console.WriteLine($"{liczbaZmiennoprzecinkowa} + {liczbaZmiennoprzecinkowa} = {wynik6}");

var wynik7 = liczbaZmiennoprzecinkowa + liczbaZmiennoprzecinkowa2; // 3.14 + 3.14 = 6.280000104904175 Dlaczego?
Console.WriteLine($"{liczbaZmiennoprzecinkowa} + {liczbaZmiennoprzecinkowa2} = {wynik7}");

// var wynik8 = liczbaZmiennoprzecinkowa + wartoscLogiczna;
// Powyższa linia daje błąd:
// Error CS0019: Operator '+' cannot be applied to operands of type 'float' and 'bool' (CS0019)

var wynik9 = liczbaZmiennoprzecinkowa + znak; // 3.14 + a = 100.14 // Dlaczego?
Console.WriteLine($"{liczbaZmiennoprzecinkowa} + {znak} = {wynik9}");

var wynik10 = liczbaZmiennoprzecinkowa2 + liczbaZmiennoprzecinkowa2; // 3.14 + 3.14 = 6.28
Console.WriteLine($"{liczbaZmiennoprzecinkowa2} + {liczbaZmiennoprzecinkowa2} = {wynik10}");

// var wynik11 = liczbaZmiennoprzecinkowa2 + wartoscLogiczna;
// Powyższa linia daje błąd:
// Error CS0019: Operator '+' cannot be applied to operands of type 'double' and 'bool' (CS0019)

var wynik12 = liczbaZmiennoprzecinkowa2 + znak; // 3.14 + a = 100.14 // Dlaczego?
Console.WriteLine($"{liczbaZmiennoprzecinkowa2} + {znak} = {wynik12}");

// var wynik13 = wartoscLogiczna + wartoscLogiczna;
// Powyższa linia daje błąd:
// Error CS0019: Operator '+' cannot be applied to operands of type 'bool' and 'bool' (CS0019)

// var wynik14 = wartoscLogiczna + znak;
// Powyższa linia daje błąd:
// Error CS0019: Operator '+' cannot be applied to operands of type 'bool' and 'char' (CS0019)

var wynik15 = znak + znak; // a + a = 194 // Dlaczego?
Console.WriteLine($"{znak} + {znak} = {wynik15}");
