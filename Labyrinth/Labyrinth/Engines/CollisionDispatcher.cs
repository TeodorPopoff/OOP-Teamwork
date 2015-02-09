namespace Labyrinth.Engines
{
    using System.Collections.Generic;
    using Labyrinth.Objects;
    using System;

    static class CollisionDispatcher
    {
        public static BattleHandler SeeForCollisions(List<GameObject> allObjects)
        {
            bool[] alreadyCollided = new bool[allObjects.Count];

            for (int firstObject = 0; firstObject < allObjects.Count; firstObject++)
            {
                for (int secondObject = 0; secondObject < allObjects.Count; secondObject++)
                {
                    GameObject first = allObjects[firstObject];
                    GameObject second = allObjects[secondObject];

                    if (first.CanCollideWith(second))
                    {
                        if (first is AttackableCreature)
                        {
                            if (second is Creature)
                            {
                                return new BattleHandler(first as AttackableCreature, second as Creature);
                                //Console.SetCursorPosition(0, 10);
                                //Console.WriteLine(first);
                                //Console.WriteLine(second);
                                //string[] input = Console.ReadLine().Split();
                                //ProcessInput(input, first as AttackableCreature, second as Creature);
                            }
                        }
                    }
                }
            }
            return new BattleHandler(null, null);
        }

        private static void StartBalle(AttackableCreature attacker, Creature defender)
        {
            while (attacker.IsAlive == true && defender.IsAlive == true)
            {
                
            }
        }

        private static void ProcessInput(string[] input, AttackableCreature attacker, Creature defender)
        {
            string firstCommand = input[0];
            switch (firstCommand)
            {
                case "attack":
                    attacker.Attack(defender);
                    (attacker as Hero).MoveBack();
                    break;
                default:
                    break;
            }
        }
    }
}
