string path = @"H:\Wit12B\AEuP\C#\02 Dateizugriff\Aufgabe_2_4_a\";
string[] zeilen = new string[5];
string[] kopiertezeilen;

for (int i = 0; i < zeilen.Length; i++)
{
    zeilen[i] = $"Das ist die Zeile {i + 1}.";
}

File.WriteAllLines("zeilen.txt", zeilen);
if (File.Exists(path + "Testdatei.txt"))
    File.Copy("zeilen.txt", @"H:\Wit12B\AEuP\C#\02 Dateizugriff\Aufgabe_2_4_a\Testdatei.txt");

if (File.Exists(path + "Testdatei.txt"))
{
    kopiertezeilen = File.ReadAllLines(path + "Testdatei.txt");
    foreach (string s in kopiertezeilen)
    {
        Console.WriteLine(s);
    }
}
else
{
    Console.WriteLine("Datei nicht vorhanden");
}