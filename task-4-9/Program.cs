// 4.9. Napisz program, który przyjmuje tablicę liczb całkowitych i zwraca
//      tablicę zawierającą tylko liczby parzyste z oryginalnej tablicy. 

string TASK_TRANSLATION = "4.9. Write a program that takes an array of " +
    "integers and returns an array containing only even numbers from " +
    "the original array.";

int[] EvenNumbersFilter(int[] array)
{
    int countEven = 0;

    // Counting the number of even numbers in the array
    foreach (int number in array)
    {
        if (number % 2 == 0)
        {
            countEven++;
        }
    }

    // Creating an array to hold only even numbers
    int[] evens = new int[countEven];
    int index = 0;

    // Adding even numbers to the array
    foreach (int number in array)
    {
        if (number % 2 == 0)
        {
            evens[index] = number;
            index++;
        }
    }

    return evens;
}


void ExecuteExamples()
{
    Random random = new Random();
    int[] examples = new int[10];

    for (int i = 0; i < examples.Length; i++) examples[i] = random.Next(1, 11);

    Console.WriteLine($"Array: {string.Join(", ", examples)}");
    Console.WriteLine($"Filtered array: {string.Join(", ", EvenNumbersFilter(examples))}");
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



Console.WriteLine("Hello, World!");

