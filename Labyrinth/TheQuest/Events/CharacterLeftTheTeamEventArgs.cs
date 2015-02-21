using System;

namespace TheQuest.Events
{
    public class CharacterLeftTheTeamEventArgs : EventArgs 
    {
        private Character character;
        private string message;

        public CharacterLeftTheTeamEventArgs(Character character, string message)
        {
            this.Character = character;
            this.Message = message;
        }

        public Character Character
        {
            get
            {
                return this.character;
            }
            set
            {
                this.character = value;
            }
        }

        public string Message
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
            }
        }
    }
}
