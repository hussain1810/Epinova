namespace MathGame.Game
{
    class GameLogic
    {
        private int _startCount, _endCount;
        private List<Rules> _rules;

        public GameLogic(
            int startCount,
            int endCount,
            List<Rules> rules
        ){
            _startCount = startCount;
            _endCount = endCount;
            _rules = rules;
        }

        public IEnumerable<string> RunGame()
        {
            var result = new List<string>();
            var range = Enumerable.Range(Math.Min(_startCount, _endCount), Math.Max(_startCount, _endCount));

            foreach (var i in _startCount > _endCount ? range.Reverse() : range)
            {
                var output = "";

                foreach (var rule in _rules) 
                {
                    if (CheckRule(i, rule.Number))
                    {
                        output += rule.Name;
                    }
                }

                if (output.Length == 0)
                    result.Add(i.ToString());
                else
                    result.Add(output);
            }

            return result;
        }

        private bool CheckRule(int number, int numberToCheckAgainst)
        {
            if (number % numberToCheckAgainst == 0)
            {
                return true;
            }

            return false;
        }
    }
}