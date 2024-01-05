// 4.1. Napisz funkcję, która przyjmuje dwa argumenty - liczbę i potęgę.
//      Funkcja ma obliczyć potęgę danej liczby i zwrócić rezultat jako wynik.

string TASK_TRANSLATION = "Task 4.1. Write a function that takes two arguments" +
    " - a number and a power. The function should calculate the power of " +
    "a given number and return the result as result.";

double Power(double number, double exponent)
{
    try
    {
        double result = Math.Pow(number, exponent);
        return result;
    }
    catch (Exception)
    {
        Console.WriteLine("An error occurred. Make sure both arguments are valid numbers.");
        throw;
    }
}

void ExecuteExamples()
{
    double[][] examples = new double[3][];
    examples[0] = new double[] { 2, 3 };
    examples[1] = new double[] { 4.4, 5.5 };
    examples[2] = new double[] { 6.6, 7.7 };

    foreach (double[] example in examples)
    {
        Console.WriteLine($"{example[0]}^{example[1]} = {Power(example[0], example[1])}");
    }
}

// -------- Execution -------- 

string LINE = new string('-', Console.WindowWidth);

Console.WriteLine(LINE);
Console.WriteLine(TASK_TRANSLATION);
Console.WriteLine(LINE);

ExecuteExamples();
Console.WriteLine(LINE);

try
{
    Console.Write("Enter a number: ");
    double number = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter an exponent: ");
    int exponent = Convert.ToInt32(Console.ReadLine());

    double result = Power(number, exponent);

    Console.WriteLine($"Result: {result}");
}
catch (FormatException)
{
    Console.WriteLine("Invalid input. Please enter valid numbers.");
}

