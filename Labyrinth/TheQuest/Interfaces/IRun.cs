using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheQuest
{
    public interface IMovable
    {
        /// <summary>
        /// How many steps the character can move
        /// </summary>
        int Range { get; set; }

        /// <summary>
        /// Moves the character right
        /// </summary>
        void MoveRight();
        /// <summary>
        /// Moves the character left
        /// </summary>
        void MoveLeft();
        /// <summary>
        /// Moves the character up
        /// </summary>
        void MoveUp();
        /// <summary>
        /// Moves the character down
        /// </summary>
        void MoveDown();
    }
}