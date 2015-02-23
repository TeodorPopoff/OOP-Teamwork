using System;

namespace TheQuest.Events
{
    public class FriendLeftTheTeamEventArgs : EventArgs 
    {
        private Friend aFriend;
        private string message;

        public FriendLeftTheTeamEventArgs(Friend aFriend, string message)
        {
            this.Friend = aFriend;
            this.Message = message;
        }

        public Friend Friend
        {
            get
            {
                return this.aFriend;
            }
            set
            {
                this.aFriend = value;
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
