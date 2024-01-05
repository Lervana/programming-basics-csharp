// Task 5.4. [PL] Napisz program który wyświetli zawartość danego katalogu
//                (pliki i foldery) wraz z informacjami na ich temat.
//           [EN] Write a program that will display the contents of
//                a given directory (files and folders) along with information
//                about them.

try
{
    string directoryPath = @"C:\path\to\your\directory"; // Change this to the directory path you want to inspect

    // Check if the directory exists
    if (Directory.Exists(directoryPath))
    {
        // Display information about the directory
        Console.WriteLine($"Contents of directory: {directoryPath}\n");

        // Get all files in the directory
        string[] files = Directory.GetFiles(directoryPath);
        Console.WriteLine("Files:");
        foreach (string file in files)
        {
            FileInfo fileInfo = new FileInfo(file);
            Console.WriteLine($"{fileInfo.Name} - Size: {fileInfo.Length} bytes, Last Modified: {fileInfo.LastWriteTime}");
        }

        // Get all subdirectories in the directory
        string[] subdirectories = Directory.GetDirectories(directoryPath);
        Console.WriteLine("\nSubdirectories:");
        foreach (string subdir in subdirectories)
        {
            DirectoryInfo subdirInfo = new DirectoryInfo(subdir);
            Console.WriteLine($"{subdirInfo.Name} - Created: {subdirInfo.CreationTime}, Last Accessed: {subdirInfo.LastAccessTime}");
        }
    }
    else
    {
        Console.WriteLine("The specified directory does not exist.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}