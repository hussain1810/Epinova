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

            List<Game.Rules> newRules = new List<Game.Rules> 
            {
                new Game.Rules("Fuzz", 4),
                new Game.Rules("Jazz", 9)
            };
            Game.Game jazzFuzz = new Game.Game(1, 100, newRules);
            jazzFuzz.RunReversedGame();
        }
    }
}