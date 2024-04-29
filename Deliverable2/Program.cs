using System;

class Coin_FlippChallenge
{
    static void Main(string[] args)
    {

        int score = 0;
        Random rand = new Random();

        Console.WriteLine("              \nWELCOME TO COIN FLIP CHALLENGE GAME\n\n");
        Console.Write("What is your name?\n>");
        string name = Console.ReadLine();


        Console.WriteLine($"Welcome {name}. Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        string response = Console.ReadLine();

        if (response.Trim().ToLower() != "yes")
        {
            Console.WriteLine($"You are a COWARD {name} !!");
            return;
        }





        for (int i = 0; i < 5; i++)
        {

            int Coin_Flipp = rand.Next(2);


            Console.Write("Heads or Tails?\n>");
            string guess = Console.ReadLine().Trim().ToLower();


            int choice;
            if (guess == "heads")
            {
                choice = 0;

            }
            else
            {

                choice = 1;
            }


            if (choice == Coin_Flipp)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }

        Console.WriteLine($"Thank you {name}. You got a score of {score}!!");
    }
}
