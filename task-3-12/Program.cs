// 3.12.Za pomocą pętli for, while oraz do…while oblicz sumę liczb od 1 do 10.

// for
int sumaFor = 0;

for (int i = 1; i <= 10; i++)
{
    sumaFor += i;
}

Console.WriteLine("Suma liczb od 1 do 10 (za pomocą pętli for): " + sumaFor);


// while
int sumaWhile = 0;
int liczbaWhile = 1;

while (liczbaWhile <= 10)
{
    sumaWhile += liczbaWhile;
    liczbaWhile++;
}

Console.WriteLine("Suma liczb od 1 do 10 (za pomocą pętli while): " + sumaWhile);


// do...while
int sumaDoWhile = 0;
int liczbaDoWhile = 1;

do
{
    sumaDoWhile += liczbaDoWhile;
    liczbaDoWhile++;
} while (liczbaDoWhile <= 10);

Console.WriteLine("Suma liczb od 1 do 10 (za pomocą pętli do-while): " + sumaDoWhile);

Console.ReadLine();