using System;

namespace Lab3DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi there, Please state your name.");

            string name = Console.ReadLine();

            Console.WriteLine("Hello {0} how are you on this fine day? Press 1 for good or 2 for bad.", name);

            int result;

            if (int.TryParse(Console.ReadLine(), out result))

            {

                if (result == 1)

                    Console.WriteLine("Well {0} I am glad to hear it, cool! Hit enter to get started!", name);

                else if (result == 2)

                    Console.WriteLine("Well {0} I am sorry to hear it, that sucks :( Hit enter to get started.", name);

                else

                    Console.WriteLine("Incorrect response");

            }

            else

                Console.WriteLine("Incorrect response");

            Console.ReadLine();

            Console.WriteLine("Please  enter a number between 1 and 100:");
            Console.WriteLine();
            bool validNumber = true;
            string input = Console.ReadLine();
            int i = int.Parse(input);


            if (i <= 100 && i >= 1)

            {
                if (i % 2 != 0 && i > 60)
                {
                    Console.WriteLine(i + " is an odd number and is greater than 60.");
                }

                else if (i % 2 != 0 && i <= 60) //redundant check based on output from if statemmment
                {
                    Console.WriteLine(i + " is an odd number and is less than 61.");
                }
                else if (i % 2 == 0 && i >= 2 && i <= 25)

                {
                    Console.WriteLine(i + " is an even number and is also less than 25");
                }

                else if (i % 2 >= 26 && i <= 60)

                {
                    Console.WriteLine(i + " is an even number.");


                }

                else if (i % 2 >= 60 && i % 2 != 0)
                {
                    Console.WriteLine(i + "  is odd.");
                }




            }
            else
            {
                Console.WriteLine(" sorry, please try a positive number.");
            }

            char action = 'b';
            while (action == 'b')
            {
                

                Console.WriteLine(" Thank you for your help. If you are finished please type 'b' ");
                action = Console.ReadKey().KeyChar;

                Console.WriteLine("Bye!");
            }
        }
            
        }
        
}

    
