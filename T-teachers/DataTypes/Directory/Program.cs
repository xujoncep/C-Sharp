
namespace Directory
{
    public class Program
    {
        static void Main(string[] args)
        {
            string absDirectory = @"D:\C#\logs\errorLog";
            System.IO.Directory.CreateDirectory(absDirectory);

            //string relDirectory = @"D:\C#\logs\desErrorLog";

            //Directory.CreateDirectory(absDirectory);

            //System.IO.Directory.CreateDirectory(absDirectory);

            // System.IO.Directory.CreateDirectory(relDirectory);

            // string[] files = System.IO.Directory.GetFiles(absDirectory);

            //foreach(var item in files)
            //{
            //    Console.WriteLine(item);
            //}

            //bool isExsists = System.IO.File.Exists(absDirectory);

            //if (isExsists)
            //{
            //    Console.WriteLine("Yes");
            //}

            //System.IO.Directory.Move(absDirectory, relDirectory);

            //System.IO.Directory.Delete(@"D:\\C#\\logs");  // this will not fire if there any file on it

            //System.IO.Directory.Delete(@"D:\\C#\\logs\\desErrorLog", true);

            //string fileName = "log.txt";

            //string dummyText = "This is a dummy text \n";

            //string filePath = Path.Combine(absDirectory, fileName);


            //File.WriteAllText(filePath, dummyText);
            //File.AppendAllText(filePath, dummyText);
            //File.AppendAllText(filePath, dummyText);
            //File.AppendAllText(filePath, dummyText);
           //File.AppendAllText(filePath, dummyText);
            //string contents = File.ReadAllText(filePath);
            //Console.WriteLine(contents);


            //string[] words = contents.Split(' ');

            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}



            bool exists = File.Exists(@"D:\C#\logs\errorLog\log.txt");

            if (exists)
            {
                Console.WriteLine("Yes");
            }
            

            Console.WriteLine("Done");

            Console.ReadKey();

        }
    }
}
