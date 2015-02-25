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

        public static BattleHandler SeeForCollisionsWithEnemies(ThorinTeam team, List<Enemy> allObjects)
        {
            foreach (var otherObj in allObjects)
            {
                if (team.CanCollideWith(otherObj))
                {
                    return new BattleHandler(team, otherObj as Enemy);
                }
            }

            return new BattleHandler(null, null);
        }

        public static bool SeeForCollisionsWithWalls(ThorinTeam team, ICollection<Wall> allWalls)
        {
            foreach (var wall in allWalls)
            {
                if (team.CanCollideWith(wall))
                {
                    return true;
                }
            }

            return false;
        }

        public static Friend SeeForCollisionsWithFriends(ThorinTeam team, ICollection<Friend> allFriends)
        {
            foreach (var friend in allFriends)
            {
                if (team.CanCollideWith(friend))
                {
                    return friend;
                }
            }

            return null;
        }

        public static Item SeeForCollisionWithItems(ThorinTeam team, List<Item> allItems)
        {
            foreach (var item in allItems)
            {
                if (team.CanCollideWith(item))
                {
                    return item;
                }
            }

            return null;
        }
    }
}
