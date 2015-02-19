namespace TheQuest
{
    public class Tauriel : Elve
    {
        private bool _isAlive = true;
        private char _symbol = 'T';

        public Tauriel(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
            
        }
    }
}