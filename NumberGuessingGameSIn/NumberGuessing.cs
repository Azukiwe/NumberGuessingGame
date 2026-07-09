using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuessingGameSIn
{
    internal class NumberGuessing
    {
        private int numberToGuess = 0;
        private int maximum;
        private int minimum;

        public NumberGuessing(int minimum, int maximum) 
        {
            GenerateRandomNumber(minimum, maximum);
        }
        void GenerateRandomNumber(int minimum, int maximum)
        {
            Random rand = new Random();
            numberToGuess = rand.Next(minimum, maximum);

            this.maximum = maximum;
            this.minimum = minimum;
        }
        public GuessResults MakeGuess(int guess)
        {
            if (guess > maximum)
            {
                return GuessResults.OutOfLimits;
            }
            else if (guess < minimum)
            {
                return GuessResults.OutOfLimits;
            }
            if (guess == numberToGuess)
            {
                GuessResults result = GuessResults.Correct;
                return GuessResults.Correct;
            }
            else if (guess < numberToGuess)
            {
                return GuessResults.TooLow;

            }
            else
            {
                return GuessResults.TooHigh;
            }
        }
    }
}
