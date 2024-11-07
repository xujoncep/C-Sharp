using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Console.WriteLine("Hello, World!");
        // Console.Write("This is the first program of w3");

        string MyText = "this is a file text";
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string filepath = Path.Combine(folderPath, "file.txt");
        
        File.WriteAllText(filepath, MyText);
    }
}
