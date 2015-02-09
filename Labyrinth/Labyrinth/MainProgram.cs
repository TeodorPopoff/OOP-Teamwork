namespace Labyrinth
{
    using Labyrinth.ConsoleThings;
    using Labyrinth.Engines;
    using Labyrinth.Enumerations;
    using Labyrinth.Interfaces;
    using Labyrinth.Objects;
    using Labyrinth.Objects.Enemies;

    class MainProgram
    {
        static void Main()
        {
            IRenderer renderer = new ConsoleRenderer(ConsoleSettings.ConsoleHeight, ConsoleSettings.ConsoleWidth);
            IUserInterface keyboard = new KeyboardInterface();
            GameObject hero = new Hero(new MatrixCoords(1, 1), new char[,] {{'@'}}, 100, 5, 5);
            GameObject enemy = new WildBoar(new MatrixCoords(2, 2), new char[,] { { '@' } });
            MainEngine engine = new MainEngine(renderer, keyboard);

            keyboard.OnDownPressed += (sender, eventInfo) => { (hero as Hero).Move(Direction.Down); };
            keyboard.OnUpPressed += (sender, eventInfo) => { (hero as Hero).Move(Direction.Top); };
            keyboard.OnRightPressed += (sender, eventInfo) => { (hero as Hero).Move(Direction.Right); };
            keyboard.OnLeftPressed += (sender, eventInfo) => { (hero as Hero).Move(Direction.Left); };

            engine.AddObject(hero);
            engine.AddObject(enemy);
            engine.Run();
        }
    }
}
