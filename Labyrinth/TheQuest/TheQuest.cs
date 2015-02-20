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


            Console.BufferHeight = Console.WindowHeight; // Remove the scrollbar

            keyboard.OnDownPressed += (sender, eventInfo) => { mainChar.Move(Direction.Down); };
            keyboard.OnUpPressed += (sender, eventInfo) => { mainChar.Move(Direction.Up); };
            keyboard.OnLeftPressed += (sender, eventInfo) => { mainChar.Move(Direction.Left); };
            keyboard.OnRightPressed += (sender, eventInfo) => { mainChar.Move(Direction.Right); };

            engine.AddObject(mainChar);
            engine.Run();
        }
    }
}
