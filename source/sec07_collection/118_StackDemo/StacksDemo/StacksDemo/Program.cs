namespace StacksDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defineing a new stack
            Stack<int> stack = new Stack<int>();
            //add elements to the stack using Push()
            stack.Push(1);
            Console.WriteLine("Top value int the stack is : {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value int the stack is : {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("Top value int the stack is : {0}", stack.Peek());

            while(stack.Count > 0)
            {
                Console.WriteLine("The Top value {0} was removed from the stack", stack.Pop());
                Console.WriteLine("Current stack count is : {0}", stack.Count);
            }
 
            //-----------------------
            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            //defineing a new stack of int
            Stack<int> myStack = new Stack<int>();

            Console.Write("the numbers in the array are :");
            //foreach number in our array
            foreach(int number in numbers)
            {
                //print it
                Console.Write(number + " ");
                //push it into our stack(add)
                myStack.Push(number);
            }

            Console.WriteLine("");
            Console.Write("the number in reverse :");
            //al long as our stack is not empty
            while(myStack.Count > 0)
            {
                //Pop it and store it in a variable
                int number = myStack.Pop();
                //print the value we popped
                Console.Write(number + " ");

            }

        }
    }
}