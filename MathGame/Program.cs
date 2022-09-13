using MathGame.Game;

namespace MathGame
{
    class Program
    {
        public static void Main(string[] args) 
        {
            List<Rules> rules = new List<Rules> 
            {
                new Rules("Fizz", 3),
                new Rules("Buzz", 5)
            };
            GameLogic fizzBuzz = new GameLogic(1, 100, rules);
            foreach (var result in fizzBuzz.RunGame())
            {
                Console.WriteLine(result);
            }
            
            List<Rules> newRules = new List<Rules> 
            {
                new Rules("Fuzz", 4),
                new Rules("Jazz", 9)
            };
            GameLogic jazzFuzz = new GameLogic(100, 1, newRules);
            foreach (var result in jazzFuzz.RunGame())
            {
                Console.WriteLine(result);
            }
        }
    }
}