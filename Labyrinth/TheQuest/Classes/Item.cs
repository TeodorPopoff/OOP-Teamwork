namespace TheQuest
{
    public abstract class Item : GameObject
    {
        protected Item(string name, string description, Location position)
            : base(name, description, position)
        {
            
        }
    }
}