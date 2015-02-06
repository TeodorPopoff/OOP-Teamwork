namespace Labyrinth.Engine
{
    using Labyrinth.Interfaces;
    using System.Collections.Generic;
    using System.Threading;

    class GameEngine
    {
        private IRenderer renderer;
        private IUserInterface userInterface;
        private List<GameObject> allObjects;

        public GameEngine(IRenderer renderer, IUserInterface userInterface)
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

                this.renderer.ClearQueue();

                foreach (var obj in allObjects)
                {
                    obj.Update();
                    this.renderer.EnqueueForRendering(obj);
                }

                this.allObjects.RemoveAll(x => x.isAlive == false);
            }
        }
    }
}
