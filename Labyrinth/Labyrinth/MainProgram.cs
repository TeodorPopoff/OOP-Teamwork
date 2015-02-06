namespace Labyrinth
{
    using Labyrinth.Engine;
    using Labyrinth.Enumerations;
    using Labyrinth.Interfaces;
    using Labyrinth.Objects;

    class MainProgram
    {
        static void Main()
        {
            IRenderer renderer = new ConsoleRenderer(20, 20);
            IUserInterface keyboard = new KeyboardInterface();
            GameObject hero = new Hero(new MatrixCoords(1, 1), new char[,] { { '@' } });
            GameEngine engine = new GameEngine(renderer, keyboard);

            keyboard.OnDownPressed += (sender, eventInfo) => { (hero as Hero).Move(Direction.Down); };
            keyboard.OnUpPressed += (sender, eventInfo) => { (hero as Hero).Move(Direction.Top); };
            keyboard.OnRightPressed += (sender, eventInfo) => { (hero as Hero).Move(Direction.Right); };
            keyboard.OnLeftPressed += (sender, eventInfo) => { (hero as Hero).Move(Direction.Left); };

            engine.AddObject(hero);
            engine.Run();
        }
    }
}
