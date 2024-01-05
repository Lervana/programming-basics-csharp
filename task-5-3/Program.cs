// Task 5.3. [PL] Napisz program, który usunie wybrany plik. 
//           [EN] Write a program that will delete the selected file.

try
{
    // Specify the path of the file to be deleted
    string filePath = @"C:\path\to\file.txt";

    // Check if the file exists
    if (File.Exists(filePath))
    {
        // Delete the file
        File.Delete(filePath);
        Console.WriteLine("File deleted successfully.");
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