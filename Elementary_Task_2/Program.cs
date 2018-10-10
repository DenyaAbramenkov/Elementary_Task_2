namespace Elementary_Task_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
   
    /// <summary>
    /// Joins a first name and a last name together into a single string.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point to programm
        /// </summary>
        /// <param name="args">Command line args</param>
        public static void Main(string[] args)
        {
            Envelope e1 = new Envelope();
            Envelope e2 = new Envelope();
            Envelope e3 = new Envelope();
            Envelope e4 = new Envelope();
            e1.Width = 5;
            e1.Height = 20;
            e1.Name = "p";
            e2.Width = 6;
            e2.Height = 30;
            e2.Name = "v";
            e3.Name = "t";
            e3.Width = 120;
            e3.Height = 3;
            e4.Width = 1;
                e4.Height = 1;
            e4.Name = "ch";
            List<Envelope> list = new List<Envelope> { e1, e4, e3, e2};
           // e1.CompareTo(e2);
            list.Sort();
            Console.ReadLine();
        }
    }
}
