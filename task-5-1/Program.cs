// 5.1. [PL] Napisz program, który wyświetli zawartość pliku tekstowego.
//      [EN] Write a program that will display the contents of a text file.

try
{
    // Specify the path of the text file
    string filePath = @"C:\path\to\your\file.txt";

    // Check if the file exists
    if (File.Exists(filePath))
    {
        // Read all text from the file and display it
        string fileContents = File.ReadAllText(filePath);
        Console.WriteLine("File Contents:");
        Console.WriteLine(fileContents);
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