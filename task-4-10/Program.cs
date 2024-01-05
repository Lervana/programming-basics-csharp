// 4.10. Napisz funkcję, która będzie generować losowe imię postaci w grze RPG.
//      Imię powinno składać się z dwóch części: imienia i nazwiska. Imię
//      powinno być wybrane losowo z listy kilku imion, a nazwisko z listy
//      kilku nazwisk. Funkcja powinna zwracać wygenerowane imię i nazwisko. 

string TASK_TRANSLATION = "4.10. Write a function that will generate " +
    "a random name for a character in an RPG game. The name should consist " +
    "of two parts: firstname and surname. The name should be chosen " +
    "randomly from a list of several names, and the surname should be " +
    "chosen randomly from a list of several names. The function should " +
    "return the generated name and surname.";

static string GenerateRandomName(string[] names, string[] surnames)
{
    Random random = new Random();
    
    string name = names[random.Next(names.Length)];
    string surname = surnames[random.Next(surnames.Length)];

    return $"{name} {surname}";
}


void Execute()
{
    string[] names = { "Aragorn", "Legolas", "Gandalf", "Frodo", "Gimli" };
    string[] surnames = { "Stormblade", "Fireheart", "Ironforge", "Shadowstalker", "Dragonborn" };

    for (int i = 0; i < 10; i++) Console.WriteLine($"Random name: {GenerateRandomName(names, surnames)}");
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
