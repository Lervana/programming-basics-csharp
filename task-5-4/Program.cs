// Task 5.4. [PL] Napisz program, który zmieni nazwę wybranego pliku. 
//           [EN] Write a program that will rename the selected file.

try
{
    // Specify the current file path and the new file name
    string currentFilePath = @"C:\path\to\current\file.txt";
    string newFileName = "newFileName.txt"; // Specify the new file name

    // Check if the current file exists
    if (File.Exists(currentFilePath))
    {
        // Extract the directory path of the current file
        string directoryPath = Path.GetDirectoryName(currentFilePath);

        // Create the new file path with the new file name
        string newFilePath = Path.Combine(directoryPath, newFileName);

        // Rename the file by moving it to the new file path
        File.Move(currentFilePath, newFilePath);
        Console.WriteLine("File renamed successfully.");
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