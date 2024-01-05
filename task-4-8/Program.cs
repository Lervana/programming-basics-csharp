// 4.8. Napisz funkcję, która przyjmuje jeden argument - tablicę liczb
//      całkowitych i zwraca wartość sumy kwadratów elementów w tablicy. 

string TASK_TRANSLATION = "4.8. Write a function that takes one argument - " +
    "an array of integers and returns the value of the sum of the " +
    "squares of the elements in the array.";

int SquareSum(int[] values)
{
    int sum = 0;

    foreach (int value in values)
    {
        sum += value * value;
    }

    return sum;
}


void ExecuteExamples()
{
    Random random = new Random();
    int[] examples = new int[10];

    for (int i = 0; i < examples.Length; i++) examples[i] = random.Next(1, 11);

    Console.WriteLine($"Array: {string.Join(", ", examples)}");
    Console.WriteLine($"Squares: {string.Join(", ", SquareSum(examples))}");   
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
