using System;

namespace C_Sharp_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Øvning 1: loop counting from 1 to 10
            int num = 1;

            while (num <= 10)
            {           
               Console.WriteLine(num); 
               num+=1;               
            }

            Console.ReadKey();


            //Øvning 2: counting backwards from X (X =userinput)

            int userInput;

            Console.Write("enter an integer\n");
            int.TryParse(Console.ReadLine(), out userInput);

            while(userInput>0)
            {
                Console.WriteLine(userInput);
                userInput -=1;
            }
        
            Console.ReadKey();


            //Øvning 3: och sen då?

            string qustion, answerUser;
            bool answer;
            int counter;

            
            
            do{ Console.WriteLine("och sen då?");
                answerUser = Console.ReadLine().ToUpper();
                
                if (answerUser = 'Q'){

                }
                
            } while (answer!=true);



        }
    }
}
