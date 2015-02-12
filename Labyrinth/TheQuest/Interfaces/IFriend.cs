using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheQuest
{
    public interface IFriend : IMovable
    {
        int BattleStrength { get; set; }
    }
}