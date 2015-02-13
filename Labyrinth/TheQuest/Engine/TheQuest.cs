using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class TheQuest
    {
        static void Main(string[] args)
        {
            Dwarf thorin = new Dwarf("Thorin", "The dwarf king", new Location(0, 0));
            Console.WriteLine(thorin.Symbol);
        }
    }
}
