namespace MathGame.Game 
{
    class Rules 
    {
        private string _name;
        private int _number;

        public Rules(
            string name,
            int number
        ){
            _name = name;
            _number = number;
        }

        public string Name { get => _name; }
        public int Number { get => _number; }
    }
}