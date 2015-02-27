namespace TheQuest
{
    using System;

    public class Warg : Enemy
    {
        public Warg(string name, Location position)
            : base(name, position)
        {
            Random rnd = new Random();
            base.BattleStrength = (double)rnd.Next(50, 400);
            base.symbol = "W";
            base.description = "Wargs are canine beasts of Middle-earth in the Misty Mountains, used especially by Orcs of Isengard and Mordor in the Third Age. They are used by Orcs as a form of transportation, in the same manner that Men and Elves use horses. They appear first in The Hobbit, attacking Thorin and Company as they traveled east from the Misty Mountains. In the Fellowship of the Ring Wargs attacked the Fellowship as they traveled to Moria. That they were Wargs and not ordinary wolves searching for food, Gandalf remarked, was evident from the fact that the carcasses of the dead Wargs were gone the next morning.[1] Later, during Theoden's retreat to Helm's Deep in Rohan, a scout reported that wolf-riders were abroad in the valley, but Wargs were not mentioned.";
        }
    }
}