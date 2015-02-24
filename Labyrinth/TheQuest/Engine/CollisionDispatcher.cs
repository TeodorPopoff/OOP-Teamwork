using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class CollisionDispatcher
    {

        public static BattleHandler SeeForCollisionsWithEnemies(ThorinTeam team, ICollection<GameObject> allObjects)
        {
            allObjects.Remove(team);

            foreach (var otherObj in allObjects)
            {
                if (team.CanCollideWith(otherObj))
                {
                    if (otherObj is IEnemy)
                    {
                        return new BattleHandler(team, otherObj as Enemy);
                    }
                }
            }

            return new BattleHandler(null, null);
        }
    }
}
