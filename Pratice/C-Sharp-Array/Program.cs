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

            int[] testArry = { 10, 20, 12, 23, 24, 25, 26, 27 };
            var result = testArry.Aggregate(0, (x, y) => x * y);



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
    }
}
