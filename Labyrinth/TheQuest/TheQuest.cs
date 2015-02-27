using System;
using System.Globalization;
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
            engine.InitAllGameObjects();

            Console.BufferHeight = Console.WindowHeight; // Remove the scrollbar

            keyboard.OnDownPressed += (sender, eventInfo) => { engine.Team.Move(Direction.Down); };
            keyboard.OnUpPressed += (sender, eventInfo) => { engine.Team.Move(Direction.Up); };
            keyboard.OnLeftPressed += (sender, eventInfo) => { engine.Team.Move(Direction.Left); };
            keyboard.OnRightPressed += (sender, eventInfo) => { engine.Team.Move(Direction.Right); };

            engine.Run();
        }
    }
}
