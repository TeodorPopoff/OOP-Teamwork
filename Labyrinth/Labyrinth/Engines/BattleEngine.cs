namespace Labyrinth.Engines
{
    using Labyrinth.ConsoleThings;
    using Labyrinth.Interfaces;
    using Labyrinth.Objects;
    using System.Collections.Generic;
    using System.Threading;
    using System;

    class BattleEngine
    {
        private IRenderer renderer;
        private AttackableCreature attacker;
        private Creature defender;
        private List<Creature> allCreatures;

        public BattleEngine(IRenderer renderer, AttackableCreature attacker, Creature defender)
        {
            this.renderer = renderer;
            this.attacker = attacker;
            this.defender = defender;
            this.allCreatures = new List<Creature>();
            InitializeBattle();
        }

        /// <summary>
        /// Set enemies at special position and puts them in allCreatures array
        /// </summary>
        public void InitializeBattle()
        {
            MatrixCoords attackerNewCoords = new MatrixCoords(ConsoleSettings.ConsoleHeight / 2, ConsoleSettings.ConsoleWidth / 2 - (ConsoleSettings.ConsoleWidth / 4));
            MatrixCoords defenderNewCoords = new MatrixCoords(ConsoleSettings.ConsoleHeight / 2, ConsoleSettings.ConsoleWidth / 2 + (ConsoleSettings.ConsoleWidth / 4));

            this.attacker.Coords = new MatrixCoords(attackerNewCoords.Row, attackerNewCoords.Col);
            this.defender.Coords = new MatrixCoords(defenderNewCoords.Row, defenderNewCoords.Col);

            this.allCreatures.Add(this.attacker);
            this.allCreatures.Add(this.defender);
        }

        public void Run()
        {
            Console.Clear();

            while (attacker.IsAlive && defender.IsAlive)
            {
                foreach (var creature in this.allCreatures)
                {
                    creature.Update();
                    this.renderer.EnqueueForRendering(creature);
                }

                this.renderer.RenderAll();
                Console.WriteLine(attacker);
                Console.WriteLine(defender);

                EnterCommand();
                DefenderAttacks();

                Thread.Sleep(150);

                this.renderer.ClearQueue();

                


            }
        }

        private void DefenderAttacks()
        {
            if (defender is AttackableCreature)
            {
                (defender as AttackableCreature).Attack(attacker);
            }
        }

        private void EnterCommand()
        {
            string[] command = Console.ReadLine().Split();
            ClearInputCommand();

            switch (command[0])
            {
                case "attack":
                    //StartAnimation();
                    this.attacker.Attack(defender);
                    //EndAnimation();
                    break;
                default:
                    break;
            }
        }

        private void EndAnimation()
        {
            throw new NotImplementedException();
        }

        private void StartAnimation()
        {
            throw new NotImplementedException();
        }

        private void ClearInputCommand()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write("\r" + new string(' ', ConsoleSettings.ConsoleWidth));
        }
    }
}
