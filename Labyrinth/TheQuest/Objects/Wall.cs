namespace TheQuest
{
    class Wall : GameObject
    {
        public Wall(char symbol, Location position, string name = "null")
            :base(symbol, name, position)
        {
        }
    }
}
