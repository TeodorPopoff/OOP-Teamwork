using System;

namespace TheQuest
{
    class TheQuest
    {
        static void Main(string[] args)
        {
            Dwarf thorin = new Dwarf("Thorin", "The dwarf king", new Location(0, 0));
            //Console.WriteLine(thorin.Symbol);

            GameObject[,] battlefield = new GameObject[10, 10];
            battlefield[0, 0] = thorin;

            DrawBattlefield(battlefield);
        }

        private static void DrawBattlefield(GameObject[,] battlefield)
        {
            for (int i = 0; i < battlefield.GetLength(0); i++)
            {
                for (int j = 0; j < battlefield.GetLength(1); j++)
                {
                    if (battlefield[i, j] == null)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(battlefield[i, j].Symbol);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
