namespace TheQuest
{
    public class Thranduil : Elve
    {
        private bool _isAlive = true;
        private char _symbol = 'L';

        public Thranduil(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
            
        }
    }
}