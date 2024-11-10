namespace Intermediate
{
    partial class Program
    {
        public class ArrayCalculator
        {
            public int Add(params int[] numbers)
            {
                var sum = 0;
                foreach (var i in numbers)
                {
                    sum += i;
                }

                return sum;
            }

        }

    }
    
}
