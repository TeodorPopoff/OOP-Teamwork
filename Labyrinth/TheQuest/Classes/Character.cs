using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheQuest
{
    public abstract class Character
    {
        private string name;

        /// <summary>
        /// What name will be displayed on screen
        /// </summary>
        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        /// <summary>
        /// Represents the power of the character in battle
        /// </summary>
        public int Strength
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        /// <summary>
        /// The location of the character on the battlefield
        /// </summary>
        public Location Position
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        /// <summary>
        /// The Unicode symbol used to draw the character on the console
        /// </summary>
        protected char Symbol
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}