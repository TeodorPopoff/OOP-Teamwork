                namespace TheQuest
{
    public interface IMagician
    {
        int SpellPower { get; }
        /// <summary>
        /// For how many moves the magiciam will stay with us
        /// </summary>
        int Presence { get; set; }
    }
}