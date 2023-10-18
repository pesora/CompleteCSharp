namespace WhyParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sum
            int sum1 = Sum(1, 2, 3);
            int sum2 = Sum(4, 5, 6, 7, 8);
            int sum3 = Sum();

            Console.WriteLine(sum1);    //6
            Console.WriteLine(sum2);    //30
            Console.WriteLine(sum3);    //0

            //average
            double average1 = Average(1, 2, 3);
            double average2 = Average(4, 5, 6, 7, 8);
            double average3 = Average();

            Console.WriteLine(average1);    //2
            Console.WriteLine(average2);    //6
            Console.WriteLine(average3);    //NaN
        }

        public static int Sum(params int[] numbers)
        {
            int total = 0; ;
            foreach(int number in numbers)
            {
                total += number;
            }
            return total;
        }

        public static double Average(params int[] numbers)
        {
            int total = 0;
            int count = 0;

            foreach(int number in numbers)
            {
                total += number;
                count++; ;
            }
            return (double)total/count;
        }
    }
}