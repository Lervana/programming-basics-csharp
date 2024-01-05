// 4.7. Napisz funkcję, która przyjmuje jeden argument - tablicę liczb
//      całkowitych i zwraca wartość iloczynu elementów w tablicy. 

using System.Diagnostics;

string TASK_TRANSLATION = "4.7. Write a function that takes one argument " +
    "- an array of numbers integers and returns the value of the product of " +
    "the elements in the array.";

int Aggregate(int[] arr)
{
    return arr.Aggregate((x, y) => x * y);
}

int Recursion(int[] arr, int index = 0)
{
    return index == arr.Length - 1 ? arr[index] : arr[index] * Recursion(arr, index + 1);
}

int ForLoop(int[] numbers)
{
    int product = 1;

    for (int i = 0; i < numbers.Length; i++)
    {
        product *= numbers[i];
    }

    return product;
}

void ExecuteExamples()
{
    Random random = new Random();
    int[] examples = new int[10];

    for (int i = 0; i < examples.Length; i++) examples[i] = random.Next(1, 10);

    int product;

    Stopwatch stopwatch = new Stopwatch();
    Console.WriteLine($"Array: {string.Join(", ", examples)}\n");

    double[] times = new double[3];

    // Aggregate
    stopwatch.Start();
    product = Aggregate(examples);
    stopwatch.Stop();
    times[0] = stopwatch.Elapsed.TotalMilliseconds;
    Console.WriteLine($"Aggregate | Result: {product} | Time: {times[0]}ms");
    stopwatch.Reset();

    // Recursion
    stopwatch.Start();
    product = Recursion(examples);
    stopwatch.Stop();
    times[1] = stopwatch.Elapsed.TotalMilliseconds;
    Console.WriteLine($"Aggregate | Result: {product} | Time: {times[1]}ms");
    stopwatch.Reset();

    // ForLoop
    stopwatch.Start();
    product = ForLoop(examples);
    stopwatch.Stop();
    times[2] = stopwatch.Elapsed.TotalMilliseconds;
    Console.WriteLine($"Aggregate | Result: {product} | Time: {times[2]}ms");
    stopwatch.Reset();
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
