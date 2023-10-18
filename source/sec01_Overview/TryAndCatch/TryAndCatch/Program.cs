namespace TryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception, please enter the correct type");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exceoption, the number was too long or too short for an int32");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Argument Null Exceoption, the value was empty");
            }
            finally {
                Console.WriteLine("This is called anywasys");
            }

            Console.ReadKey();
        }
    }
}