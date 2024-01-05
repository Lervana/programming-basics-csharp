// Task 5.4. [PL] Napisz program, który sprawdzi, czy dany plik istnieje. 
//           [EN] Write a program that will check whether a given file exists.

try
{
    // Specify the file path to check
    string filePath = @"C:\path\to\file.txt";

    // Check if the file exists
    if (File.Exists(filePath))
    {
        Console.WriteLine("The specified file exists.");
    }
    else
    {
        Console.WriteLine("The specified file does not exist.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}

