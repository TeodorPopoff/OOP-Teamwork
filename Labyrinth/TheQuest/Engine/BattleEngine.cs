using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheQuest
{
    class BattleEngine
    {
        private ConsoleRenderer renderer;
        private Friend friend;
        private Enemy enemy;
        private List<Character> allCreatures;

        public BattleEngine(ConsoleRenderer renderer, Friend friend, Enemy enemy)
        {
            this.renderer = renderer;
            this.friend = friend;
            this.enemy = enemy;
            this.allCreatures = new List<Character>();
        }

        /// <summary>
        /// Set enemies at special position and puts them in allCreatures array
        /// </summary>
        public void InitializeBattle()
        {
            Location attackerNewCoords = new Location(ConsoleSettings.ConsoleHeight / 2, ConsoleSettings.ConsoleWidth / 2 - (ConsoleSettings.ConsoleWidth / 4));
            Location defenderNewCoords = new Location(ConsoleSettings.ConsoleHeight / 2, ConsoleSettings.ConsoleWidth / 2 + (ConsoleSettings.ConsoleWidth / 4));

            this.friend.Position = new Location(attackerNewCoords.Y, attackerNewCoords.X);
            this.enemy.Position = new Location(defenderNewCoords.Y, defenderNewCoords.X);

            this.enemy.HiddenSymbol = this.enemy.Name;

            this.allCreatures.Add(this.friend);
            this.allCreatures.Add(this.enemy);
        }

        public void Run()
        {
            Console.Clear();
            Location startedCoordsOfThorin = new Location(this.friend.Position.X, this.friend.Position.Y);
            Location startedCoordsOfEnemy = new Location(this.enemy.Position.X, this.enemy.Position.Y);

            InitializeBattle();

            while (friend.IsAlive && enemy.IsAlive)
            {
                foreach (var creature in this.allCreatures)
                {
                    //creature.Update();
                    this.renderer.EnqueueForRendering(creature);
                }

                this.renderer.RenderAll();
                Console.WriteLine("Enter command \"attack\" to attack");
                Console.WriteLine(friend);

                FriendAttacks();
                EnemyAttacks();

                Thread.Sleep(150);

                this.renderer.ClearQueue();
            }

            this.friend.Position = startedCoordsOfThorin;
            this.enemy.Position = startedCoordsOfEnemy;
            Console.Clear();
        }

        private void EnemyAttacks()
        {

        }

        private void FriendAttacks()
        {
            string[] command = Console.ReadLine().Split();
            ClearInputCommand();

            switch (command[0])
            {
                case "attack":
                    Location startPosition = new Location(this.friend.Position.X, this.friend.Position.Y);
                    Location endPosition = new Location(this.enemy.Position.X, this.enemy.Position.Y);

                    MakeAnimation(this.friend, this.enemy, endPosition, "move to right");
                    (this.friend as ThorinTeam).Fight(this.enemy);
                    MakeAnimation(this.friend, this.enemy, startPosition, "move to left");
                    break;
                default:
                    break;
            }
        }


        private void MakeAnimation(Character attacker, Character defender, Location positionToGo, string whereToAttack)
        {
            while (attacker.Position != positionToGo)
            {
                this.renderer.EnqueueForRendering(attacker);
                this.renderer.EnqueueForRendering(defender);
                this.renderer.RenderAll();
                switch (whereToAttack)
                {
                    case "move to right":
                        attacker.Position = new Location(attacker.Position.X + 1, attacker.Position.Y);
                        break;
                    case "move to left":
                        attacker.Position = new Location(attacker.Position.X - 1, attacker.Position.Y);
                        break;
                    default:
                        break;
                }
                
                this.renderer.ClearQueue();
                Thread.Sleep(150);
            }
        }

        private void ClearInputCommand()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write("\r" + new string(' ', ConsoleSettings.ConsoleWidth));
        }
    }
}
