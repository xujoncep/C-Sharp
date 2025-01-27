using System.Text;

namespace C_Sharp_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Reverse a single Given string 
            string names = "sahabuddin";
            Console.WriteLine("Original: " + names);
            string reverse = string.Empty;

            for (int i = names.Length - 1; i >= 0; i--)
            {
                reverse = reverse + names[i];

            }
            Console.WriteLine("Reversed: " + reverse);

            
            // reverse each word of a sentence
            string sentense = "This is a dummy text";
            Console.WriteLine("This is Original Sentence: "+ sentense);
            StringBuilder reverseSentence = new StringBuilder();

            var words = sentense.Split(' ');

            foreach (var item in words)
            {
                string rev= string.Empty;

                for(int i = item.Length - 1;i >= 0;i--)
                {
                    rev = rev + item[i];
                }

                reverseSentence.Append(rev + " "); 
            }
            Console.WriteLine("This is Reversed Sentence: "+ reverseSentence);

            //Check palindrome of string

            string palString = "madam"; //Here uppercase and lowercase is not same 
            string palTemp = string.Empty;

            for(int i = palString.Length - 1; i >=0; i--)
            {
                palTemp = palTemp + palString[i];
            }

            if( palString == palTemp)
            {
                Console.WriteLine("This is Paliendrome");
            }

            else
            {
                Console.WriteLine(" This is not a Paliendrome");
            }

            //Remove duplicate values from a given string 

            string dupString = "bangladesh";
            HashSet<char> dup = new HashSet<char>();

            foreach (var item in dupString)
            {
                if(dup.Contains(item) == false)
                {
                    dup.Add(item);
                }

            }
            StringBuilder WithOutDup = new StringBuilder();
            foreach (var item in dup)
            {
                WithOutDup.Append(item);
                
            }

            Console.WriteLine("Before Duplication Removed: " + dupString);
            Console.WriteLine("After Duplication Removed: " + WithOutDup);

            //Find Possible SubString

            string masterString = "duplication";
            var subStrings = new StringBuilder();
            masterString.Substring(0);

            //for (int i=0; i <= masterString.Length -1; i++)
            //{
            //    for(int j=i; j < masterString.Length; j++)
            //    {
            //        subStrings.Append(masterString[j]);
            //    }
            //    subStrings.Append(" ");
            //}

        }
    }
}
