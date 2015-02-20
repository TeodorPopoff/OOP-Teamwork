using System;

namespace TheQuest
{
    class TheQuest
    {
        static void Main(string[] args)
        {
            KeyListener keyboard = new KeyListener();
            ConsoleRenderer renderer = new ConsoleRenderer(ConsoleSettings.ConsoleHeight, ConsoleSettings.ConsoleWidth);
            GameEngine engine = new GameEngine(keyboard, renderer);
            Dwarf mainChar = new Dwarf("asd", new Location(1, 1));

            engine.AddObject(mainChar);
            engine.Run();
        }
    }
}
