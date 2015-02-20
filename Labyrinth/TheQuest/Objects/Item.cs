namespace TheQuest
{
    public abstract class Item : GameObject
    {
        protected Item(char symbol, string name, Location position)
            : base(symbol, name, position)
        {
            
        }
    }
}