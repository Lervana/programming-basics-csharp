// Task 5.4. [PL] Napisz program, który wczyta z pliku imiona Twoich ulubionych
//                bohaterów ze świata filmu lub literatury, a następnie wypisze
//                je alfabetycznie w kolejności rosnącej oraz malejącej. 
//           [EN] Write a program that will read the names of your favorite
//                characters from the world of film or literature from a file
//                and then print them alphabetically in ascending
//                and descending order.

try
{
    string filePath = @"path\to\your\names\file.txt"; // Change the file path to your names file

    // Check if the file exists
    if (File.Exists(filePath))
    {
        // Read names from the file
        string[] names = File.ReadAllLines(filePath);

        // Display original names
        Console.WriteLine("Original names:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Sort names in ascending order and display them
        Array.Sort(names);
        Console.WriteLine("\nNames sorted in ascending order:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Sort names in descending order and display them
        Array.Sort(names, (x, y) => String.Compare(y, x));
        Console.WriteLine("\nNames sorted in descending order:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
    else
    {
        Console.WriteLine("The names file does not exist.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}