using System;
using System.Collections.Generic;
using System.Text;
using TheQuest.Events;

namespace TheQuest
{
    public class ThorinTeam : GameObject, IMove
    {
        private List<Character> companions;
        private bool isAlive;
        private bool canRide = false;
        private bool canFly = false;
        private int ridingDistance = 0;
        private int flyingDistance = 0;

<<<<<<< HEAD
        public event CharacterJoinedTheTeamEventHandler CharacterJoinedTheTeam;
        public event CharacterLeftTheTeamEventHandler CharacterLeftTheTeam;
        public event CharacterDiedInBattleEventHandler CharacterDiedInBattle;
=======
>>>>>>> origin/master

        /// <summary>
        /// Constructs the team by creating its leader - Thorin, adds it to the companions collection,
        /// and places the team at the starting position.
        /// </summary>
        public ThorinTeam()
            : base("Thorin's Team", new Location(0, 0))
        {
            Dwarf thorin = new Dwarf(
                "Thorin",
                new Location(0, 0));
            this.companions.Add(thorin);
            base.symbol = thorin.Symbol;
            base.description = "Our group of brave and loyal friends.";
        }

        /// <summary>
        /// Shows if th eteam can avoid battle by running away.
        /// </summary>
        public bool CanRide
        {
            get
            {
                return this.canRide;
            }
        }

        /// <summary>
        /// Shows if th eteam can avoid battle by flying away.
        /// </summary>
        public bool CanFly
        {
            get
            {
                return this.CanFly;
            }
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
        /// Returns the description of the team.
        /// </summary>
        public override string Description
        {
            get
            {
                return base.description;
            }
        }

        /// <summary>
        /// returns a string to be used to draw the team on the battlefield.
        /// </summary>
        public override string Symbol
        {
            get
            {
                return base.symbol;
            }
        }


        /// <summary>
        /// Adds a new member to the team.
        /// </summary>
        /// <param name="companion">The Character object to add.</param>
        /// <returns>Fires event each time a companion is added.</returns>
        public void AddCompanion(Character companion)
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
            string message = string.Format("{0} just joined the team. Your strength has now increased to {1}.",
                companion.Name, this.Strength);
            CharacterJoinedTheTeamEventArgs joinedEventArgs = new CharacterJoinedTheTeamEventArgs(companion, message);
            CharacterJoinedTheTeam(companion, joinedEventArgs);
        }

        /// <summary>
        /// Removes a member from the team.
        /// If the member is a Magigician, also removes the Spell effect on the team's strength.
        /// </summary>
        /// <param name="companion">The Character to remove.</param>
        /// <returns>Void</returns>
        public void RemoveCompanion(Character companion)
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
                //return string.Format("{0} has just left the team on some other Magicians' business. Your strength is now {1}",
                //    companion.Name, this.Strength);
            }

            if (this.companions.Count == 0)
            {
                this.isAlive = false;
            }
            //else
            //{
            //    return string.Format("{0} was lost in battle... Eternal glory on his name forevermore!",
            //        companion.Name);
            //}

        }

        /// <summary>
        /// Adds additional powers via Items of different types.
        /// </summary>
        /// <param name="item">Item object that can give the team ability to fly, ride or increase its strength.</param>
        public void AddItem(Item item)
        {
            if (item is IFly)
            {
                this.canFly = true;
                this.flyingDistance += (item as IFly).FlyingEffect;
            }
            else if (item is IRide)
            {
                this.canRide = true;
                this.ridingDistance += (item as IRide).RidingEffect;
            }
            else if (item is IFood || item is IWeapon)
            {
                this.companions[0].BattleStrength += (item as IFood).StrengthEffect;
            }
        }

        /// <summary>
        /// Moves the whole team to a new place on the battlefield,
        /// determined by its ridingDistance and supplied parameter direction.
        /// </summary>
        /// <param name="direction">The direction to move to.</param>
        public void RideAway(Direction direction)
        {
            if (this.canRide == false)
            {
                throw new InvalidOperationException("The team doesn't have riding ability.");
            }
            Move(direction, this.ridingDistance);
            this.canRide = false;
            this.ridingDistance = 0;
        }

        /// <summary>
        /// Moves the whole team to a new place on the battlefield,
        /// determined by its ridingDistance and supplied parameter direction.
        /// </summary>
        /// <param name="direction">The direction to move to.</param>
        public void FlyAway(Direction direction)
        {
            if (this.canFly == false)
            {
                throw new InvalidOperationException("The team doesn't have flying ability.");
            }
            Move(direction, this.flyingDistance);
            this.canFly = false;
            this.flyingDistance = 0;
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

            foreach (Character member in this.companions)
            {
                if (member is IMagician)
                {
                    (member as IMagician).Presence--;
                    if ((member as IMagician).Presence == 0)
                    {
                        RemoveCompanion(member);
                        string message = string.Format("{0} has juft left the team on some magician's business. Your strength has now decreased to {1}.",
                            member.Name, this.Strength);
                        CharacterLeftTheTeamEventArgs leftArgs = new CharacterLeftTheTeamEventArgs(member, message);
                        this.CharacterLeftTheTeam(member, leftArgs);
                    }
                }
            }
        }

        /// <summary>
        /// Implements battle with an enemy.
        /// Changes IsAlive to false if the battle is lost.
        /// Fires event every time when a member of the team dies in the battle.
        /// </summary>
        /// <param name="enemy">The enemy to fight with.</param>
        public void Fight(Character enemy)
        {
            if (!(enemy is IEnemy))
            {
                throw new ArgumentException("Parameter enemy must implement interface IEnemy.");
            }
            int teamStrengthAtBattleStart = this.Strength;
            if (teamStrengthAtBattleStart <= enemy.BattleStrength)
            {
                this.isAlive = false;
                return;
            }

            while (enemy.BattleStrength > 0)
            {
                Character currentFighter = this.companions[this.companions.Count - 1];
                int fighterStrength = currentFighter.BattleStrength;
                currentFighter.BattleStrength -= enemy.BattleStrength;

                if (!currentFighter.IsAlive)
                {
                    enemy.BattleStrength -= fighterStrength;
                    this.RemoveCompanion(currentFighter);
                    string message = string.Format("{0} perished in battle with evil {1}s. Eternal glory upon his name!",
                        currentFighter.Name, enemy.GetType());
                    CharacterDiedInBattleEventArgs diedArgs = new CharacterDiedInBattleEventArgs(currentFighter, message);
                    CharacterDiedInBattle(currentFighter, diedArgs);
                }
            }
        }

        /// <summary>
        /// Returns the size, composition and strength of the team.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Thorin's Team: \n");
            result.Append(string.Format("Size: {0}\n", this.Count));
            result.Append("Members: { ");
            StringBuilder members = new StringBuilder();
            foreach (Character member in this.companions)
            {
                members.Append(member.Name + ", ");
            }
            members = members.Remove(members.Length - 2, 2);
            result.Append(members);
            result.Append(" }\n");
            result.Append(string.Format("Strength: {0}", this.Strength));

            return result.ToString();
        }
    }
}