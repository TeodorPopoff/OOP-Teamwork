namespace TheQuest
{
    public class Wall : GameObject
    {
        public Wall(char symbol, Location position, string name = "null")
            :base(name, position)
        {
        }

        public override string Description
        {
            get { throw new System.NotImplementedException(); }
        }

        public override string Symbol
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}
