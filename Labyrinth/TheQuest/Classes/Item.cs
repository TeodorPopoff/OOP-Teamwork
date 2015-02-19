namespace TheQuest
{
    public abstract class Item : GameObject
    {
        protected Item(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
            
        }
    }
}