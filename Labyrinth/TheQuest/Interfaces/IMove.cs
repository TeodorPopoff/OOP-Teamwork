using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheQuest
{
    public interface IMove
    {
        void Move(Direction direction, int step);
    }
}