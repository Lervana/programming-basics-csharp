// 4.11. Napisz funkcję, która sortuje tablicę według algorytmu sortowania
//       bąbelkowego. 

string TASK_TRANSLATION = "4.11. Write a function that sorts an array using " +
    "the bubble sort algorithm.";

void BubbleSort(int[] array)
{
    int n = array.Length;
    bool swapped;

    do
    {
        swapped = false;
        for (int i = 1; i < n; i++)
        {
            if (array[i - 1] > array[i])
            {
                // Swap elements
                int temp = array[i - 1];
                array[i - 1] = array[i];
                array[i] = temp;
                swapped = true;
            }
        }
        n--;
    } while (swapped);
}


void Execute()
{
    Random random = new Random();
    int[] examples = new int[10];

    for (int i = 0; i < examples.Length; i++) examples[i] = random.Next(1, 101);

    Console.WriteLine($"Array: {string.Join(", ", examples)}");
    BubbleSort(examples);
    Console.WriteLine($"Sorted: {string.Join(", ", examples)}");
}

// -------- Execution -------- 

string LINE = new string('-', Console.WindowWidth);

Console.WriteLine(LINE);
Console.WriteLine(TASK_TRANSLATION);
Console.WriteLine(LINE);

Console.WriteLine();
Execute();
Console.WriteLine();
Console.WriteLine(LINE);
