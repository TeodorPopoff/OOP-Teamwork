namespace Labyrinth.Interfaces
{
    using System;

    interface IUserInterface
    {
        event EventHandler OnLeftPressed;

        event EventHandler OnRightPressed;

        event EventHandler OnUpPressed;

        event EventHandler OnDownPressed;

        void ProcessInput();
    }
}
