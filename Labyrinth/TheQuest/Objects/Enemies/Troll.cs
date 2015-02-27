namespace TheQuest
{
    using System;

    public class Troll : Enemy
    {
        public Troll(string name, Location position)
            : base(name, position)
        {
            Random rnd = new Random();
            base.BattleStrength = (double)rnd.Next(50, 400);
            base.symbol = "O";
            base.description = "Trolls are a very large and monstrous (ranging from between 8 to 10 feet tall), and for the most part unintelligent (references are made about more cunning trolls[1]) humanoid race inhabiting Middle-earth.";
        }
    }
}