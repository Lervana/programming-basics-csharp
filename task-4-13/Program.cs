// 4.13. Napisz funkcję, którą przyjmuje jako jedyny argument tekst,
//       zwielokrotnia go dwudziestokrotnie a następnie zmienia co trzecią
//       literę na dużą, a pozostałe na małe. Zmodyfikowany tekst powinien
//       być zwracany przez funkcję. 

using System.Text;

string TASK_TRANSLATION = "4.13. Write a function that takes text as its " +
    "only argument, multiplies it twenty times and then changes every third " +
    "letter to uppercase and the rest to lowercase. The modified text " +
    "should be returned by the function.";

string ManipulateText(string text)
{
    StringBuilder result = new StringBuilder();

    // Repeats the text twenty times
    for (int i = 0; i < 20; i++)
    {
        result.Append(text);
    }

    // Changes every third letter to uppercase and the rest to lowercase
    for (int i = 0; i < result.Length; i++)
    {
        if ((i + 1) % 3 == 0)
        {
            result[i] = char.ToUpper(result[i]);
        }
        else
        {
            result[i] = char.ToLower(result[i]);
        }
    }

    return result.ToString();
}

void Execute()
{
    string inputText = "Sample text to manipulate.";

    Console.WriteLine("Original text:");
    Console.WriteLine(inputText);

    string modifiedText = ManipulateText(inputText);

    Console.WriteLine("\nModified text:");
    Console.WriteLine(modifiedText);

    Console.ReadLine();
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