namespace TheQuest
{
    public interface ISpy
    {
        /// <summary>
        /// How many fileds in each direction the character can uncover
        /// </summary>
        int Range { get; }

        /// <summary>
        /// How many times the character is allowed to apply its skill
        /// </summary>
        int Times { get; }

        /// <summary>
        /// Uncovers part of the battlefield determined by Range.
        /// </summary>
        void Spy();
    }
}