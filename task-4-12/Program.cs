// 4.12. Napisz funkcję, która sortuje tablicę zawierającą oceny studentów
//       (tablica tablic), według ich średniej oceny: w porządku rosnącym
//       lub malejącym, w zależności od parametru. 

string TASK_TRANSLATION = "4.12. Write a function that sorts an array " +
    "containing students' grades (array of arrays) by their average grade: " +
    "in ascending or descending order, depending on the parameter.";

void SortStudentGrades(double[][] studentGrades, bool sortByAverageAscending, bool sortGradesAscending)
{
    Array.Sort(studentGrades, (x, y) =>
    {
        double averageX = x.Average();
        double averageY = y.Average();

        if (sortByAverageAscending)
        {
            int averageComparison = averageX.CompareTo(averageY);
            return sortGradesAscending ? averageComparison : -averageComparison;
        }
        else
        {
            int averageComparison = averageY.CompareTo(averageX);
            return sortGradesAscending ? averageComparison : -averageComparison;
        }
    });

    if (!sortByAverageAscending && sortGradesAscending || sortByAverageAscending && !sortGradesAscending)
    {
        foreach (var grades in studentGrades)
        {
            Array.Sort(grades);
        }
    }
    else
    {
        foreach (var grades in studentGrades)
        {
            Array.Sort(grades);
            Array.Reverse(grades);
        }
    }
}

void DisplayStudentGrades(double[][] studentGrades)
{
    foreach (var grades in studentGrades)
    {
        double average = grades.Average();
        Console.WriteLine($"Student grades: [{string.Join(", ", grades)}], Average: {average:F2}");
    }
}


void ExecuteExaple(double[][] studentGrades, bool sortByAverageAscending, bool sortGradesAscending)
{
    Console.WriteLine($"\nExample: sortByAverageAscending = {sortByAverageAscending}, sortGradesAscending = {sortGradesAscending}");

    SortStudentGrades(studentGrades, sortByAverageAscending, sortGradesAscending);
    Console.WriteLine("\nStudent grades after sorting:");
    DisplayStudentGrades(studentGrades);
}

void Execute()
{
    double[][] studentGrades = new double[][]
    {
            new double[] { 4, 4, 5 },
            new double[] { 3.5, 4.5, 4.5 },
            new double[] { 5, 4.5, 4.5 },
            new double[] { 4, 3.5, 4.5 }
    };

    Console.WriteLine("Student grades before sorting:");
    DisplayStudentGrades(studentGrades);

    ExecuteExaple(studentGrades, true, true);
    ExecuteExaple(studentGrades, true, false);
    ExecuteExaple(studentGrades, false, true);
    ExecuteExaple(studentGrades, false, false);
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
