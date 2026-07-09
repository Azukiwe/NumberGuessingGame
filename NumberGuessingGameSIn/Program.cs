namespace NumberGuessingGameSIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            bool inputValid = false;

            while (!gameOver)
            {
                int maximum = 0;
                string difficulty = string.Empty;
                inputValid = false;

                while (!inputValid)
                {
                    Console.WriteLine("What difficulty would you like?(E),(M),(H)");
                    difficulty = Console.ReadLine();
                    difficulty = difficulty.ToUpper(); //convert to uppercase so that it is not case sensitive

                    if ((difficulty == "E") || (difficulty == "M") || (difficulty == "H"))
                    {
                        inputValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter E, M, or H.");
                        inputValid = false;
                    }
                }
                    if (difficulty == "E")
                    {
                        maximum = 10;
                    }
                    else if (difficulty == "M")
                    {
                        maximum = 50;
                    }
                    else
                    {
                        maximum = 1000;
                    }
                    NumberGuessing numberGuessing = new NumberGuessing(1, maximum);
                    bool guessed = false;

                    while (!guessed)
                    {

                        Console.WriteLine("Please enter your guess");
                        string guess = Console.ReadLine();
                        GuessResults result = numberGuessing.MakeGuess(int.Parse(guess));

                        if (result == GuessResults.TooLow)
                        {
                            Console.WriteLine("Your Guess is too low.Please try again");
                        }
                        else if (result == GuessResults.TooHigh)
                        {
                            Console.WriteLine("Your Guess is too high.Please try again");
                        }
                        else if (result == GuessResults.Correct)
                        {
                            Console.WriteLine("Your Guess is correct. You win!");
                                guessed = true;
                        }
                        else if (result == GuessResults.OutOfLimits)
                        {
                            Console.WriteLine("Out of Range, are you kidding me! Please try again");
                        }
                    }
                inputValid = false;
                string playAgain = string.Empty;

                    while (!inputValid)
                    {
                        Console.WriteLine("Do you want to play again? (Y/N)");
                        playAgain = Console.ReadLine();

                        playAgain = playAgain.ToUpper();//convert to uppercase so that it is not case sensitive

                        if ((playAgain == Decision.Y.ToString()) || (playAgain == Decision.N.ToString()))
                        {
                            inputValid = true;

                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter Y or N.");

                        }
                    }
                    if (playAgain == "Y")
                    {
                        gameOver = false;
                    }
                    else
                    {
                        gameOver = true;
                    }
                }
            }

        }
    }

