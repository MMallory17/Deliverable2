using System;
using System.Diagnostics.Metrics;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
        Console.WriteLine("What is your name?");
        String name = Console.ReadLine();
        Console.WriteLine("Welcome " + (name)  + " Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        String answer = Console.ReadLine();
        
        Random random = new Random();
        bool result = random.Next(0, 1) != 0; 
        int attempts = 1;
        int num7 = 4;


        if (answer == "No")
        {
            Console.WriteLine("You are a coward " + name);

        }
        if (answer == "Yes") {
            Console.WriteLine("Heads or Tails?");
        }

        for (int i = 0; i < 5; i++)
          
            if (Console.ReadLine() != answer)
            {
                Console.WriteLine("Correct!");

                
                Console.WriteLine("Heads or Tails?");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
      Console.WriteLine("Thank you " +  name + " You got a score of " + num7!);












    }    
}
