// 4.2. Napisz funkcję, która przyjmuje jeden argument - tablicę liczb
//      całkowitych. Funkcja ma zwrócić sumę wszystkich elementów tablicy. 

string TASK_TRANSLATION = "Task 4.2. Write a function that takes one argument" +
    " - an array of numbers total. The function is supposed to return the sum" +
    " of all the elements of the array.";

double Sum(int[] array)
{
    return array.Sum();
}

void ExecuteExamples()
{
    int[][] examples = new int[3][];
    examples[0] = new int[] { 1, 2, 3 };
    examples[1] = new int[] { 4, 5, 6, 7 };
    examples[2] = new int[] { 1000, 10000, 100000, 1000000 };

    foreach (int[] example in examples)
    {
        Console.WriteLine($"Suma liczb [{string.Join(", ", example)}] to {Sum(example)}.");
    }
}

// -------- Execution -------- 

string LINE = new string('-', Console.WindowWidth);

Console.WriteLine(LINE);
Console.WriteLine(TASK_TRANSLATION);
Console.WriteLine(LINE);

ExecuteExamples();
Console.WriteLine(LINE);
