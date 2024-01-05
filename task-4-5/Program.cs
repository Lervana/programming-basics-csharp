// 4.5. Napisz funkcję, która przyjmuje jeden argument - liczbę całkowitą
//      i zwraca wartość silni tej liczby. Zastosuj rekurencję. 

string TASK_TRANSLATION = "4.5. Write a function that takes one argument - " +
    "an integer and returns the factorial value of this number. Use recursion.";

int Factorial(int value)
{
    if (value <= 1)
    {
        Console.Write("1 = ");
        return 1;
    }
    else
    {
        Console.Write($"{value} * ");
        return value * Factorial(value - 1);
    }
}

void ExecuteExamples()
{
    int[] examples = Enumerable.Range(1, 15).ToArray();
    Array.Reverse(examples);

    foreach (int example in examples)
    {
        Console.Write($"{example}! = ");
        Console.WriteLine($"{Factorial(example)}");
    }
}

// -------- Execution -------- 

string LINE = new string('-', Console.WindowWidth);

Console.WriteLine(LINE);
Console.WriteLine(TASK_TRANSLATION);
Console.WriteLine(LINE);

Console.WriteLine();
ExecuteExamples();
Console.WriteLine();
Console.WriteLine(LINE);
