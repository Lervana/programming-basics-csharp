// Task 5.2. [PL] Napisz program, który skopiuje zawartość jednego pliku do drugiego.
//           [EN] Write a program that copies the contents of one file to another.

try
{
    // Specify the paths of the source and destination files
    string sourceFilePath = @"C:\path\to\source\file.txt";
    string destinationFilePath = @"C:\path\to\destination\file.txt";

    // Check if the source file exists
    if (File.Exists(sourceFilePath))
    {
        // Copy the contents of the source file to the destination file
        File.Copy(sourceFilePath, destinationFilePath, true);
        Console.WriteLine("File copied successfully.");
    }
    else
    {
        Console.WriteLine("The source file does not exist.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}