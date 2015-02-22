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
            ThorinTeam team = new ThorinTeam();
            team.AddCompanion(mainChar);

            Console.BufferHeight = Console.WindowHeight; // Remove the scrollbar

            keyboard.OnDownPressed += (sender, eventInfo) => { team.Move(Direction.Down); };
            keyboard.OnUpPressed += (sender, eventInfo) => { team.Move(Direction.Up); };
            keyboard.OnLeftPressed += (sender, eventInfo) => { team.Move(Direction.Left); };
            keyboard.OnRightPressed += (sender, eventInfo) => { team.Move(Direction.Right); };

            engine.AddObject(mainChar);
            engine.Run();
        }
    }
}
