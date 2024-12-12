
//Merged two arry and then sort it and print

//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = { 4, 2, 7 };

//int[] arr3 = arr1.Concat(arr2).ToArray();
//int[] oldarr = new int[6] ;

//Array.Copy(arr3,oldarr,6);

//Array.Sort(arr3);

//int [] newarr = arr3.OrderBy(x => x)
//                    .ToArray();

//foreach (int i in arr3)
//{

//    Console.WriteLine(i);
//}

// Make every string first latter uppercase.

//string[] words = { "hello", "hi" };

//string[] UpperWords = words.Select( words => words[0].ToString().ToUpper() + words.Substring(1)).ToArray();

//foreach (string word in UpperWords)
//{
//    Console.WriteLine(word);
//}

List<int> evenList = new List<int>();
List<int> oddList = new List<int>();

for(int i=1; i<10; i++)
{
    if (i % 2 == 0)
    {
        evenList.Add(i);
    }

    else
    {
        oddList.Add(i);
    }

}


Console.WriteLine("Even arry:");
foreach(int i in evenList)
{
    Console.Write(i +" ");
}

Console.WriteLine("\nOdd arry:");
foreach (int i in oddList)
{
    Console.Write(i +" ");
}