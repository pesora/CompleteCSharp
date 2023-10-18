//using 'params' key word

namespace ParamsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";


            ParamsMethod("This", "is", "a", "long", "string", "I", "have", "no", "idea", "when", "It's", "going", "to", "end", "....");
            ParamsMethod(); // I can keep going

            ParamsMethod2(price, pi, at, book);
            ParamsMethod2("Hello", 5.3, '$');

        }

        //Console.WriteLine(string format, params object[] arg)
        public static void ParamsMethod(params string[] sentece)
        {
            for(int i = 0; i < sentece.Length; i++)
            {
                Console.Write(sentece[i] + " ");
            }
            Console.WriteLine();
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }


    }
}