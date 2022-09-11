using System;

namespace MathGame
{
    class Program
    {
        public static void Main(string[] args) 
        {
            List<Game.Rules> rules = new List<Game.Rules> 
            {
                new Game.Rules("Fizz", 3),
                new Game.Rules("Buzz", 5)
            };
            Game.Game fizzBuzz = new Game.Game(1, 100, rules);
            fizzBuzz.RunGame();
        }
    }
}