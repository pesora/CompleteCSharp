﻿namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(20);

            Console.WriteLine(t2.Equals(t1));
        }
    }
}