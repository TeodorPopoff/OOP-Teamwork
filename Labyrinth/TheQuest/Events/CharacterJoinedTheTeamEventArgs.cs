using System;

namespace TheQuest.Events
{
    public class CharacterJoinedTheTeamEventArgs : EventArgs 
    {
        private Friend character;
        private string message;

        public CharacterJoinedTheTeamEventArgs(Friend character, string message)
        {
            this.Character = character;
            this.Message = message;
        }

        public Friend Character
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
