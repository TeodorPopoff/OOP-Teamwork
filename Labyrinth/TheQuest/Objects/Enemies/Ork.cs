namespace TheQuest
{
    using System;

    public class Ork : Enemy
    {
        public Ork(string name, Location position)
            : base(name, position)
        {
            Random rnd = new Random();
            base.BattleStrength = (double)rnd.Next(50, 400);
            base.symbol = "O";
            base.description = "Orcs were the most commonplace villains serving the Dark Powers, a race of sentient beings bred by the evil Vala Melkor during the time of the Great Darkness. The Dark Lord Sauron, and later the wizard Saruman, also bred them and used them as soldiers and henchmen to do various evil deeds across Middle-earth.";
        }
    }


}