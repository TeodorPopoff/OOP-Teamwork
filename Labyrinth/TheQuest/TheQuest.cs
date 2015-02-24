using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace TheQuest
{
    class TheQuest
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            KeyListener keyboard = new KeyListener();
            ConsoleRenderer renderer = new ConsoleRenderer(ConsoleSettings.ConsoleHeight, ConsoleSettings.ConsoleWidth);
            GameEngine engine = new GameEngine(keyboard, renderer);
            Friend mainChar = new Dwarf("asd", new Location(2, 2));
            Enemy enemy = new Ork("ork", new Location(3, 3));
            ThorinTeam team = new ThorinTeam();
            Elrond elrond = new Elrond("elrond", new Location(10, 10));
            team.AddCompanion(mainChar);

            Console.BufferHeight = Console.WindowHeight; // Remove the scrollbar

            keyboard.OnDownPressed += (sender, eventInfo) => { team.Move(Direction.Down); };
            keyboard.OnUpPressed += (sender, eventInfo) => { team.Move(Direction.Up); };
            keyboard.OnLeftPressed += (sender, eventInfo) => { team.Move(Direction.Left); };
            keyboard.OnRightPressed += (sender, eventInfo) => { team.Move(Direction.Right); };

            engine.AddObject(elrond);
            engine.AddObject(team);
            engine.AddObject(enemy);

            engine.Run();
        }
    }
}
