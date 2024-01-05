// 4.6. Napisz funkcję, która przyjmuje jeden argument - tablicę liczb
//      całkowitych i zwraca wartość największego elementu w tablicy. 

string TASK_TRANSLATION = "4.6. Write a function that takes one argument " +
    "- an array of integers and returns the value of the largest element " +
    "in the array.";

int Max(int[] values)
{
    return values.Max();
}

void ExecuteExamples()
{
    Random random = new Random();
    int[] examples = new int[10];

    for (int i = 0; i < examples.Length; i++) examples[i] = random.Next(1, 101);

    Console.WriteLine($"Array: {string.Join(", ", examples)}");
    Console.WriteLine($"Max: {Max(examples)}");
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
