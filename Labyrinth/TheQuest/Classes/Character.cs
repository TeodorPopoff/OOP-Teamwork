namespace TheQuest
{
    /// <summary>
    /// A base class for all living things that will participate in the game.
    /// All of the races will inherit from it.
    /// </summary>
    public abstract class Character : GameObject
    {
        protected Character(string name, string description, Location position)
            : base(name, description, position)
        {

        }

        public abstract bool IsAlive
        {
            get;
        }
    }
}