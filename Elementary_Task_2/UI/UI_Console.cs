using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary_Task_2
{
    class UI_Console
    {
        public static void CallMenu()
        {        
            const int START_COUNT_OF_ARGS = 1; 
            string[] args = Environment.GetCommandLineArgs();
            switch (args.Length)
            {
                case START_COUNT_OF_ARGS:
                    bool continueNext;
                    do
                    {
                        continueNext = false;
                        try
                        {
                            Console.WriteLine("Input height of first envelope:");
                            int height = int.Parse(Console.ReadLine());
                            Console.WriteLine("Input width of first envelope:");
                            int width = int.Parse(Console.ReadLine());
                            Envelope firstEnvelope = Envelope.EnvelopeInitialize(height, width);

                            Console.WriteLine("Input height of second envelope:");
                            height = int.Parse(Console.ReadLine());
                            Console.WriteLine("Input width of second envelope:");
                            width = int.Parse(Console.ReadLine());
                            Envelope secondEnvelope = Envelope.EnvelopeInitialize(height, width);

                            if (firstEnvelope.CompareTo(secondEnvelope) == 1)
                            {
                                Console.WriteLine("The first envelope is placed in the second");
                            }
                            else if (secondEnvelope.CompareTo(firstEnvelope) == 1)
                            {
                                Console.WriteLine("The second envelope is placed in the first");
                            }
                            else
                            {
                                Console.WriteLine("Can`t put one envelope in another");
                            }
                            Console.WriteLine("To continue press y/Y or yes/YES:");
                            string userAnsver = Console.ReadLine().ToLower();
                            continueNext = (userAnsver == "y" | userAnsver == "yes") ? true : false;
                        } 
                            catch (Exception)
                        {
                            Instruction();
                        }     
                    }
                    while (continueNext);
                    break;
                default:
                    Instruction();
                    break;
            }
        }
        public static void Instruction()
        {
            Console.WriteLine("To get answer about envepole fitting you shold input one by one 4 args:"
                              + Environment.NewLine
                              + "Height and Width of first enveope, and than same parametres of second"
                              + Environment.NewLine
                              + "Height and Width must be in int format");
        }
    }
}
