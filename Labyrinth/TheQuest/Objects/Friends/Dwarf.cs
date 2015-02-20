using System;

namespace TheQuest
{
    public class Dwarf : Character
    {
        private const char DefaultSymbol = 'D';
        private const int DefaultHealthPoints = 100;

        public Dwarf(string name, Location position, int healthPoints = Dwarf.DefaultHealthPoints)
            : base(DefaultSymbol, name, position, healthPoints)
        {
        }

        
    }
}