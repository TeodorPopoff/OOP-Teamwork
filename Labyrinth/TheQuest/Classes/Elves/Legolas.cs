namespace TheQuest
{
    public class Legolas : Elve
    {
        private bool _isAlive = true;
        private char _symbol = 'L';

        public Legolas(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
            
        }

    }
}