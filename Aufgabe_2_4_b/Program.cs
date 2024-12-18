string actual = Directory.GetCurrentDirectory();

Console.WriteLine("Aktueller Pfad: " + actual);

Directory.CreateDirectory(actual + @"\my_directory");

string[] directories = Directory.GetDirectories(@"C:\");

foreach (string directory in directories)
{
    Console.WriteLine(directory.Substring(3));
}

string[] files = Directory.GetFiles(actual);

foreach (string file in files)
{
    Console.WriteLine(file.Substring(actual.Length + 1));
}