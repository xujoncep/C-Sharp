using System.Collections;

namespace C_Sharp_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Variable number of item summation
            Console.WriteLine(Sum(1, 3, 3));
            Console.WriteLine(Sum(1, 4.5,4.34));

           
            //Duplicate value finding into an array
            
            int[] unSortArray = { 23,5,3,15,7 };
            string[] names = { "ab", " jhon", "bob", "alice", "ab", "bob" };

            var temp1 = unSortArray.Reverse();
            var temp2 = unSortArray.Average();
            var temp3 =  unSortArray.Max();
            var temp4 = unSortArray.ElementAt(2);
           
            
            var temp5 = unSortArray.GroupBy(x => x).Where( x => x.Count() > 1).Select(x => x);
            foreach (var item in temp5)
            {
                Console.WriteLine(item.Key); 
            }
            var temp6 = names.GroupBy(x => x).Where( x => x.Count() > 1).Select( x => x.Key);

            foreach (var item in temp6)
            {
                Console.WriteLine(item);
            }

           
            //Arry Sorting aescending order 
            int length = unSortArray.Length;

            foreach (var item in unSortArray)
            {
                for (int i = 0; i < length - 1; i++)
                {
                    if (unSortArray[i] > unSortArray[i + 1])
                    {
                        int temp = unSortArray[i];
                        unSortArray[i] = unSortArray[i + 1];
                        unSortArray[i + 1] = temp;
                    }

                }
            }

            //Arry descending order
            foreach (var item in unSortArray)
            {
                for (int i = 0; i < length - 1; i++)
                {
                    if (unSortArray[i] < unSortArray[i + 1])
                    {
                        int temp = unSortArray[i];
                        unSortArray[i] = unSortArray[i + 1];
                        unSortArray[i + 1] = temp;
                    }

                }
            }
            
            //Finding Multiplication is 200

            int[] testArry = { 10, 20, 12, 23 };
            var ansElement = new ArrayList();
            int index = 1;
            foreach (var item in testArry)
            {
                
                for(int i = index; i < testArry.Length;i++)
                {
                    if (item*testArry[i] ==200)
                    {
                        ansElement.Add(item);
                        ansElement.Add(testArry[i]);
                    }
                }
                index++;
            }

            //Reverse an Array

            int[] orininalArray = { 1, 3, 3, 4, 4, 5, 6, 2 };
            int[] reverseArray = new int[orininalArray.Length];
            for(int i = orininalArray.Length-1, j = 0; i >= 0; i--, j++)
            {
                reverseArray[j] = orininalArray[i];
            }

            Console.WriteLine("Orizinal Array");
            foreach (var item in orininalArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nReverse Array");
            foreach (var item in reverseArray)
            {
                Console.Write(item + " ");
            }
            Array.ForEach(reverseArray,item => Console.Write(item + " "));

            // Binary Search Iterration 
            int[] sortArray = { 1, 2, 3, 4, 6, 8, 9, 33 };

            var res = BinarySearchRecursive(sortArray, 8, 0, sortArray.Length - 1);
            //var res2 = BinarySearch(sortArray, 8);

            Console.WriteLine($"Recursive : {res} \n Iterative:  ");

            //Array Last item print
            char[] latter = new char[] { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine(latter[^1]);
            Console.ReadKey();
        }

       
        public static int Sum(params int[] item)
        {
            int sum = 0;
            foreach (int i in item)
            {
                sum += i;
            }
            return sum;
        }

        public static double Sum(params double[] item)
        {
            double sum = 0;
            foreach (double i in item)
            {
                sum += i;
            }
            return sum;
        }

        public static int BinarySearch(int[] array, int item)
        {
            int left = 0;
            int right = array.Length - 1;
            int middle = (left + right) / 2;

            while (left <= right)
            {
                if (array[middle] == item)
                {
                    return middle;
                }

                else if (item < array[middle])
                {
                    right = middle - 1;
                }

                else if (item > array[middle])
                {
                    left = middle + 1;
                }

            }
            return -1;
        }

        public static int BinarySearchRecursive(int[] array, int item, int left , int right)
        {
            int middle = (left + right) / 2;
            while (left <= right )
            {
                if (array[middle] == item)
                {
                    return middle;
                }
                else if (item < array[middle])
                {
                    return BinarySearchRecursive(array, item, left, middle - 1);
                   
                }
                else if (item > array[middle])
                {
                   return BinarySearchRecursive(array , item, middle + 1, right);
                    
                }

            }

            return -1;
        }
    }
}
