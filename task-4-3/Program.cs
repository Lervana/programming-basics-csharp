// 4.3. Napisz funkcję, która wyświetli podany poniżej trójkąt. Jego szerokość
//      podstawy zależy od tego, co podał użytkownik. Za znak “=” podstaw
//      spację. Funkcja ma zezwalać jedynie na liczby nieujemne nieparzyste.
//
//      Przykład działania:
//      > Enter the width: 1
//      > *
//      >
//      > Enter the width: 2
//      > An invalid value was entered, please enter an odd number.
//      >
//      > Enter the width: 3
//      > =*
//      > ***
//      >
//      > Enter the width: 5
//      > ==*
//      > =***
//      > *****
//      >
//      > Enter the width: 7
//      > ===*
//      > ==***
//      > =*****
//      > *******

string TASK_TRANSLATION = "Write a function that will display the triangle " +
    "given below. Its width basics depends on what the user provided. " +
    "For the '=' sign, substitute space. The function is supposed to " +
    "only allow non-negative odd numbers.　" +
    "\n\n" +
    "Example:\n\n" +
    "> Enter the width: 1\n" +
    "> *\n" +
    ">\n" +
    "> Enter the width: 2\n" +
    "> An invalid value was entered, please enter an odd number.\n" +
    ">\n" +
    "> Enter the width: 3\n" +
    "> =*\n" +
    "> ***\n" +
    ">\n" +
    "> Enter the width: 5\n" +
    "> ==*\n" +
    "> =***\n" +
    "> *****\n" +
    ">\n" +
    "> Enter the width: 7\n" +
    "> ===*\n" +
    "> ==***\n" +
    "> =*****\n" +
    "> *******";

void Render(int value)
{
    if (value <= 0)
    {
        Console.WriteLine($"Podano niepoprawną wartość: {value} (mniejszą niż 1)");
    }
    else if (value % 2 == 0)
    {
        Console.WriteLine($"Podano niepoprawną wartość: {value} (liczba parzysta)");
    }
    else
    {

        for (int i = 1; i <= value; i += 2)
        {
            int spaceCount = (value - i) / 2;
            string spaces = new string(' ', spaceCount);
            string equals = new string('*', i);

            Console.WriteLine(spaces + equals);
        }
    }
}

void ExecuteExamples()
{
    int[] examples = Enumerable.Range(1, 9).ToArray();

    foreach (int example in examples)
    {
        Console.WriteLine($"Value: {example}");
        Render(example);
        Console.WriteLine();
    }
}

// -------- Execution -------- 

string LINE = new string('-', Console.WindowWidth);

Console.WriteLine(LINE);
Console.WriteLine(TASK_TRANSLATION);
Console.WriteLine(LINE);

Console.WriteLine();
ExecuteExamples();
Console.WriteLine(LINE);
