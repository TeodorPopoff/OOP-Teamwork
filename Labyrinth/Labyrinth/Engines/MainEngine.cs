﻿namespace Labyrinth.Engines
{
    using Labyrinth.ConsoleThings;
    using Labyrinth.Interfaces;
    using Labyrinth.Objects;
    using System;
    using System.Collections.Generic;
    using System.Threading;

    class MainEngine
    {
        private IRenderer renderer;
        private IUserInterface userInterface;
        private List<GameObject> allObjects;

        public MainEngine(IRenderer renderer, IUserInterface userInterface)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
        }

        public void AddObject(GameObject obj)
        {
            this.allObjects.Add(obj);
        }

        public void Run()
        {
            while (true)
            {
                this.renderer.RenderAll();

                Thread.Sleep(150);

                this.userInterface.ProcessInput();

                BattleHandler battle = CollisionDispatcher.SeeForCollisions(allObjects);

                if (battle)
                {
                    StartBattle(battle);
                }

                this.renderer.ClearQueue();

                foreach (var obj in allObjects)
                {
                    obj.Update();
                    this.renderer.EnqueueForRendering(obj);
                }

                this.allObjects.RemoveAll(x => x.IsAlive == false);
            }
        }

        /// <summary>
        /// Starts the battle in other console screen
        /// </summary>
        /// <param name="battle">the battle which you want to start</param>
        private void StartBattle(BattleHandler battle)
        {
            IRenderer battleRenderer = new ConsoleRenderer(ConsoleSettings.ConsoleHeight, ConsoleSettings.ConsoleWidth);
            BattleEngine battleEngine = new BattleEngine(battleRenderer, battle.Attacker, battle.Defender);

            battleEngine.Run();
        }

    }
}