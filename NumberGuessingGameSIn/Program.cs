namespace NumberGuessingGameSIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What difficulty would you like?(E),(M),(H)");
            string diifficulty = Console.ReadLine();

            if (diifficulty == "E")
            {
                maximum = 10;
            }
            else if (diifficulty == "M")
            {
                maximum = 50;
            }
            else
            {
                maximum = 1000;
            }
            NumberGuessing numberGuessing = new NumberGuessing(1, maximum);
            bool guessed =false;

            while ()
            {

                Console.WriteLine("Please enter your guess");
                string guess = Console.ReadLine();
                GuessResults result = numberGuessing.MakeGuess(int.Parse(guess));

                if (result == GuessResults.TooLow)
                {
                    Console.WriteLine("Your Guess is too low.Please try again")
                }
                else if (result == GuessResults.TooHigh)
                {
                    Console.WriteLine("Your Guess is too low.Please try again")
                }
                else if (result == GuessResults.Correct)
                {
                    Console.WriteLine("Your Guess is correct. You win!")
                        guessed = true;
                }
                else if (result == GuessResults.OutOfLimits)
                {
                    Console.WriteLine("Out of Range, are you kidding me! Please try again")
                }
            }
        }
    }
}
