using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading Text from a File
            //exchange the adress of the file with the one you want to use
            string text = System.IO.File.ReadAllText(@"D:\Sunshine\CSharp\CompleteCSharp\source\sec10_Polymorphism and more\148_ReadTextFile\ReadFile\textfile.txt");

            Console.WriteLine("Textfile contains the following text: {0}", text);

            //Receive the Text line by line.
            string[] lines = System.IO.File.ReadAllLines(@"D:\Sunshine\CSharp\CompleteCSharp\source\sec10_Polymorphism and more\148_ReadTextFile\ReadFile\textfile.txt");

            Console.WriteLine("Content of the file line by line:");
            foreach(string line in lines)
            {
                //\t is a tab
                Console.WriteLine( "\t" + line );
            }

            //To keep the Console open.
            Console.Read();
        }
    }
}
