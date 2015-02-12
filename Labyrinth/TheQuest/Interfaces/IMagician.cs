using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheQuest
{
    public interface IMagician
    {
        int SpellPower { get; set; }
        /// <summary>
        /// For how many moves the magiciam will stay with us
        /// </summary>
        int Presence { get; set; }
    }
}