// 4.15. Zmodyfikuj zadanie 9 z listy 2, tak by uprościć kod poprzez użycie
//       tablic, pętli i funkcji.

string TASK_TRANSLATION = "4.15. Modify task 9 from list 2 to simplify " +
    "the code by using arrays, loops, and functions.";

void PrintAlignedTable(string[][] table)
{
    int[] columnWidths = new int[table[0].Length];

    // Determine maximum column widths
    for (int i = 0; i < table.Length; i++)
    {
        for (int j = 0; j < table[i].Length; j++)
        {
            int length = table[i][j].Length;
            if (length > columnWidths[j])
            {
                columnWidths[j] = length;
            }
        }
    }

    // Print top border
    Console.Write(new string('-', columnWidths.Sum() + table[0].Length * 3 + 1));
    Console.WriteLine();

    // Print table header
    Console.Write("| ");
    for (int i = 0; i < table[0].Length; i++)
    {
        Console.Write(table[0][i].PadRight(columnWidths[i]) + " | ");
    }
    Console.WriteLine();

    // Print middle border
    Console.Write("|");
    for (int i = 0; i < table[0].Length; i++)
    {
        Console.Write(new string('-', columnWidths[i]) + "--|");
    }
    Console.WriteLine();

    // Print table data
    for (int i = 1; i < table.Length; i++)
    {
        Console.Write("| ");
        for (int j = 0; j < table[i].Length; j++)
        {
            Console.Write(table[i][j].PadRight(columnWidths[j]) + " | ");
        }
        Console.WriteLine();
    }

    // Print bottom border
    Console.Write(new string('-', columnWidths.Sum() + table[0].Length * 3 + 1));
    Console.WriteLine();
}

void PrintExample(string title, string[][] exampleA)
{
    Console.WriteLine(title);
    PrintAlignedTable(exampleA);
}

void Execute()
{
    // 2.9. Stwórz program wyświetlający poniższe tablice prawdy, wynik każdego
    //      z obliczeń ma być zapisany jako operacja logiczna. W zadaniu można
    //      wykorzystać tylko takie elementy jak: zmienne, Console.WriteLine,
    //      operatory logiczne oraz Convert.ToInt32:
    //      (a) a OR  b
    //      (b) a AND b
    //      (c) (~ a OR c) OR(~b OR c)
    //      (d) [(~a OR ~c) OR(~a OR b)] AND ~b
    //      (e) [(~a AND ~b) OR(a AND b)] OR (a AND ~c)

    string[] exampleA(bool a, bool b)
    {
        return new string[] { Convert.ToInt32(a).ToString(), Convert.ToInt32(b).ToString(), Convert.ToInt32(a || b).ToString() };
    }

    PrintExample("a) a OR b", new string[][]{
        new string[] { "a", "b", "a v b" },
        exampleA(false, false),
        exampleA(false, true),
        exampleA(true, false),
        exampleA(true, true)
    });

    string[] exampleB(bool a, bool b)
    {
        return new string[] { Convert.ToInt32(a).ToString(), Convert.ToInt32(b).ToString(), Convert.ToInt32(a && b).ToString() };
    }

    PrintExample("b) a AND b", new string[][]{
        new string[] { "a", "b", "a ∧ b" },
        exampleB(false, false),
        exampleB(false, true),
        exampleB(true, false),
        exampleB(true, true)
    });

    string[] exampleC(bool a, bool b, bool c)
    {
        bool notA = !a;
        bool notB = !b;
        bool notAorC = notA || c;
        bool notBorC = notB || c;
        bool notAorC_OR_notBorC = notAorC || notBorC;

        return new string[] {
            Convert.ToInt32(a).ToString(),
            Convert.ToInt32(b).ToString(),
            Convert.ToInt32(c).ToString(),
            Convert.ToInt32(notA).ToString(),
            Convert.ToInt32(notB).ToString(),
            Convert.ToInt32(notAorC).ToString(),
            Convert.ToInt32(notBorC).ToString(),
            Convert.ToInt32(notAorC_OR_notBorC).ToString()
        };
    }

    PrintExample("c) (~a OR c) OR (~b OR c)", new string[][]{
        new string[] { "a", "b", "c", "~a", "~b", "~a v c", "~b OR c", "(~a v c) v (~b v c)" },
        exampleC(false, false, false),
        exampleC(false, false, true),
        exampleC(false, true, false),
        exampleC(false, true, true),
        exampleC(true, false, false),
        exampleC(true, false, true),
        exampleC(true, true, false),
        exampleC(true, true, true),
    });

    string[] exampleD(bool a, bool b, bool c)
    {
        bool notA = !a;
        bool notB = !b;
        bool notC = !c;
        bool notA_OR_notC = notA || notC;
        bool notA_OR_B = notA || b;
        bool notAorNotC_OR_notAorB = notA_OR_notC || notA_OR_B;
        bool notAorNotCorNotAorB_AND_notB = notAorNotC_OR_notAorB && notB;

        return new string[] {
            Convert.ToInt32(a).ToString(),
            Convert.ToInt32(b).ToString(),
            Convert.ToInt32(c).ToString(),
            Convert.ToInt32(notA).ToString(),
            Convert.ToInt32(notB).ToString(),
            Convert.ToInt32(notC).ToString(),
            Convert.ToInt32(notA_OR_notC).ToString(),
            Convert.ToInt32(notA_OR_B).ToString(),
            Convert.ToInt32(notAorNotC_OR_notAorB).ToString(),
            Convert.ToInt32(notAorNotCorNotAorB_AND_notB).ToString()
        };
    }

    PrintExample("d) [(~a OR ~c) OR (~a OR b)] AND ~b", new string[][]{
        new string[] { "a", "b", "c", "~a", "~b", "~c", "~a OR ~c", "~a OR b", "[(~a OR ~c) OR (~a OR b)]", "[(~a OR ~c) OR (~a OR b)] AND ~b" },
        exampleD(false, false, false),
        exampleD(false, false, true),
        exampleD(false, true, false),
        exampleD(false, true, true),
        exampleD(true, false, false),
        exampleD(true, false, true),
        exampleD(true, true, false),
        exampleD(true, true, true),
    });

    string[] exampleE(bool a, bool b, bool c)
    {
        bool notA = !a;
        bool notB = !b;
        bool notC = !c;
        bool notA_AND_notB = notA && notB;
        bool A_AND_B = a && b;
        bool notAandNotB_OR_AandB = notA_AND_notB || A_AND_B;
        bool A_AND_notC = a && notC;
        bool notAandNotBorAandB_OR_AandNotC = notAandNotB_OR_AandB || A_AND_notC;

        return new string[] {
            Convert.ToInt32(a).ToString(),
            Convert.ToInt32(b).ToString(),
            Convert.ToInt32(c).ToString(),
            Convert.ToInt32(notA).ToString(),
            Convert.ToInt32(notB).ToString(),
            Convert.ToInt32(notC).ToString(),
            Convert.ToInt32(notA_AND_notB).ToString(),
            Convert.ToInt32(A_AND_B).ToString(),
            Convert.ToInt32(notAandNotB_OR_AandB).ToString(),
            Convert.ToInt32(A_AND_notC).ToString(),
            Convert.ToInt32(notAandNotBorAandB_OR_AandNotC).ToString(),
        };
    }

    PrintExample("e) [(~a AND ~b) OR (a AND b)] OR (a AND ~c)", new string[][]{
        new string[] {"a", "b", "c", "~a", "~b", "~c", "~a ∧ ~b", "a ∧ b", "(~a ∧ ~b) v (a ∧ b)", "a ∧ ~c", "[(~a ∧ ~b) v (a ∧ b)] v (a ∧ ~c)" },
        exampleE(false, false, false),
        exampleE(false, false, true),
        exampleE(false, true, false),
        exampleE(false, true, true),
        exampleE(true, false, false),
        exampleE(true, false, true),
        exampleE(true, true, false),
        exampleE(true, true, true),
    });
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