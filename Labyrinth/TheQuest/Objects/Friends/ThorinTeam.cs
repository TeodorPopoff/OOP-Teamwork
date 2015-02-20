using System;
using System.Collections.Generic;

namespace TheQuest
{
    public class ThorinTeam : IMove
    {
        private List<Character> companions;
        private Location position;
        private bool isAlive;
        private string symbol;

        /// <summary>
        /// Constructs the team by creating its leader - Thorin, adds it to the companions collection,
        /// and places the team at the starting position.
        /// </summary>
        public ThorinTeam()
        {
            this.position = new Location(0, 0);
            Dwarf thorin = new Dwarf(
                "Thorin",
                new Location(0, 0));
            this.companions.Add(thorin);
            this.symbol = thorin.Symbol;
        }

        /// <summary>
        /// The total strength of the team
        /// </summary>
        public int Strength
        {
            get
            {
                int strength = 0;
                foreach (Character companion in this.companions)
                {
                    strength += companion.BattleStrength;
                }
                return strength;
            }
        }

        /// <summary>
        /// Gives the number of companions that are currently inside the team.
        /// </summary>
        public int Count
        {
            get
            {
                return this.companions.Count;
            }
        }

        /// <summary>
        /// Adds a new member to the team.
        /// </summary>
        /// <param name="companion">The Character object to add.</param>
        /// <returns>A message with info who was added and how was the team strength affected.</returns>
        public string AddCompanion(Character companion)
        {
            if (!(companion is IFriend))
            {
                throw new InvalidOperationException("You can only add characters that implement IFriend to Thorin's team.");
            }

            if (companion is IMagician)
            {
                foreach (Character member in this.companions)
                {
                    member.BattleStrength *= (companion as IMagician).SpellPower;
                }
            }

            this.companions.Add(companion);

            return string.Format("{0} just joined the team. Your strength has now increased to {1}.",
                companion.Name, this.Strength);
        }

        /// <summary>
        /// Removes a member from the team.
        /// If the member is a Magigician, also removes the Spell effect on the team's strength.
        /// </summary>
        /// <param name="companion">The Character to remove.</param>
        /// <returns>A string message with info on who has left the company / died in battle.</returns>
        public string RemoveCompanion(Character companion)
        {
            if (!this.companions.Contains(companion))
            {
                throw new ArgumentException("This companion does not exist in the team.");
            }

            this.companions.Remove(companion);

            if (companion is IMagician)
            {
                foreach (Character member in this.companions)
                {
                    member.BattleStrength /= (companion as IMagician).SpellPower;
                }
                return string.Format("{0} has just left the team on some other Magicians' business. Your strength is now {1}",
                    companion.Name, this.Strength);
            }
            else
            {
                return string.Format("{0} was lost in battle... Eternal glory on his name forevermore!",
                    companion.Name);
            }

        }

        /// <summary>
        /// Moves the whole team to a new position on the battlefield.
        /// </summary>
        /// <param name="direction">In what direction to move.</param>
        /// <param name="step">What distance to move.</param>
        public void Move(Direction direction, int step)
        {
            foreach (Character companion in this.companions)
            {
                companion.Move(direction, step);
            }

            foreach (Character  member in this.companions)
            {
                if (member is IMagician)
                {
                    (member as IMagician).Presence--;
                    if ((member as IMagician).Presence == 0)
                    {
                        RemoveCompanion(member);
                    }
                }
            }
        }
    }
}