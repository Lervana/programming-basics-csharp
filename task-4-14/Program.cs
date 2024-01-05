// 4.14. Napisz program obliczający zaliczki miesięczne na podatek od dochodów
//       za rok 2021. W tablicy 12-elementowej podane są dochody brutto
//       miesięczne w zł. W wyniku działania funkcji ma być zwrócona tablica
//       obliczająca wysokość zaliczek odprowadzanych do urzędu skarbowego
//       w poszczególnych miesiącach. Przyjmij, że przedsiębiorca rozlicza
//       się na zasadach ogólnych, według skali podatkowej (stawka podatkowa
//       12% i 32% - kiedy dochody przekraczają 120 000 zł).

using System.Globalization;

string TASK_TRANSLATION = "4.14. Write a program that calculates monthly " +
    "income tax advances for 2021. The 12-element table shows gross " +
    "monthly income in PLN. As a result of the function, a table will be " +
    "returned calculating the amount of advance payments paid to the tax " +
    "office in individual months. Assume that the entrepreneur settles " +
    "accounts on general principles, according to the tax scale (tax rate " +
    "12% and 32% - when income exceeds PLN 120,000).";

decimal[] CalculateTaxAdvances(decimal[] monthlyIncomes)
{
    decimal[] taxAdvances = new decimal[12];
    decimal yearlyIncome = 0;

    // Calculate yearly income
    foreach (decimal income in monthlyIncomes)
    {
        yearlyIncome += income;
    }

    // Calculate monthly tax advances
    decimal yearlyTax = CalculateYearlyTax(yearlyIncome);

    for (int i = 0; i < 12; i++)
    {
        decimal monthlyTax = (yearlyTax / 12);
        taxAdvances[i] = monthlyTax;
    }

    return taxAdvances;
}

decimal CalculateYearlyTax(decimal yearlyIncome)
{
    decimal yearlyTax = 0;

    if (yearlyIncome <= 85528) // 12% rate up to 85,528 PLN
    {
        yearlyTax = yearlyIncome * 0.12M;
    }
    else // 32% rate above 85,528 PLN
    {
        yearlyTax = 85528 * 0.12M + (yearlyIncome - 85528) * 0.32M;
    }

    return yearlyTax;
}


void Execute()
{
    decimal[] monthlyIncomes = {
            10000, 11000, 10500, 12000, 12500, 13000,
            11500, 11200, 10800, 11500, 11800, 12200
        };

    decimal[] taxAdvances = CalculateTaxAdvances(monthlyIncomes);

    Console.WriteLine("Monthly Tax Advances for 2021:");

    // Specify Polish currency symbol (PLN) using CultureInfo
    CultureInfo plCulture = new CultureInfo("pl-PL");

    for (int i = 0; i < 12; i++)
    {
        Console.WriteLine($"Month {i + 1}: {taxAdvances[i].ToString("C", plCulture)}");
    }
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