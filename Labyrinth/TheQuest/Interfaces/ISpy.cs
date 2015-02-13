namespace TheQuest
{
    public interface ISpy
    {
        /// <summary>
        /// How many fileds in each direction the character can uncover
        /// </summary>
        int Range { get; set; }
        /// <summary>
        /// How many times the character is allowed to apply its skill
        /// </summary>
        int Times { get; set; }
    }
}