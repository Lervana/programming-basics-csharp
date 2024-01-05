// 4.4. Napisz funkcję, która wyświetli podany poniżej trójkąt. Jego szerokość
//      podstawy i wysokość zależy od tego, co podał użytkownik. Za znak “=”
//      podstaw spację. Funkcja ma zezwalać jedynie na liczby nieujemne.
//
//      Przykład działania:
//      > Podaj wysokość: 1
//      > *
//      >
//      > Podaj wysokość: 2
//      > ==*
//      > =*=*
//      >
//      > Podaj wysokość: 3
//      > ==*
//      > =*=*
//      > *=*=*
//      >
//      > Podaj wysokość: 4
//      > ===*
//      > ==*=*
//      > =*=*=*
//      > *=*=*=*
//      >
//      > Podaj wysokość: 5
//      > ====*
//      > ===*=*
//      > ==*=*=*
//      > =*=*=*=*
//      > *=*=*=*=*
//      >
//      > Podaj wysokość: 6
//      > =====*
//      > ====*=*
//      > ===*=*=*
//      > ==*=*=*=*
//      > =*=*=*=*=*
//      > *=*=*=*=*=*
//      >

string TASK_TRANSLATION = "Write a function that will display the triangle " +
    "given below. Its width base and height depends on what the user " +
    "provided. For the '=' sign substitute a space. The function is supposed" +
    " to only allow non-negative numbers.\n\n " +
    "\n\n" +
    "Example:\n\n" +
    "> Enter the width: 1\n" +
    "> *\n" +
    ">\n" +
    "> Enter the width: 2\n" +
    ">  * \n" +
    "> * * \n" +
    ">\n" +
    "> Enter the width: 3\n" +
    ">   *\n" +
    ">  * *\n" +
    "> * * *\n" +
    ">\n" +
    "> Enter the width: 4\n" +
    ">    *\n" +
    ">   * *\n" +
    ">  * * *\n" +
    "> * * * *\n" +
    ">\n" +
    "> Enter the width: 5\n" +
    ">     *\n" +
    ">    * *\n" +
    ">   * * *\n" +
    ">  * * * * \n" +
    "> * * * * *\n" +
    ">\n" +
    "> Enter the width: 6\n" +
    ">      *\n" +
    ">     * *\n" +
    ">    * * *\n" +
    ">   * * * * \n" +
    ">  * * * * *\n" +
    "> * * * * * *\n" +
    ">\n" +
    "> Enter the width: 7\n" +
    ">       *\n" +
    ">      * *\n" +
    ">     * * *\n" +
    ">    * * * *\n" +
    ">   * * * * *\n" +
    ">  * * * * * *\n" +
    "> * * * * * * *\n\n";

void Render(int value)
{
    if(value <= 0)
    {
        Console.WriteLine($"Podano niepoprawną wartość: {value} (mniejszą niż 1)");
    }
    else
    {
        Console.WriteLine($"Podano wartość: {value}");

        for (int i = 1; i <= value; i++)
        {
            string offset = new(' ', value - i);
            string stars = new('*', i);
            Console.WriteLine(offset + stars.Replace("*", "* "));
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
