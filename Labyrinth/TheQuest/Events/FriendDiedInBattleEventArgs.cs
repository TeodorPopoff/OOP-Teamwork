using System;

namespace TheQuest.Events
{
    public class FriendDiedInBattleEventArgs : EventArgs 
    {
        private Friend aFriend;
        private string message;

        public FriendDiedInBattleEventArgs(Friend aFriend, string message)
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
