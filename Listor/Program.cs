using System;
using System.Collections.Generic;

namespace Listapåspel
{
    class Program
    {
        static void Main()
        {
            List<string> spellista = new List<string>();

            spellista.Add("Minecraft");
            spellista.Add("Fortnite");
            spellista.Add("Genshin Impact");
            spellista.Add("Rust");
            spellista.Add("Roblox");
            spellista.Add("Factorio");

            foreach (string spel in spellista)
            {
                Console.WriteLine(spel);
            }

            Console.WriteLine("Alla spel kostar 10 dollar");
            Console.WriteLine("Hur många vill du köpa ?");
            string buy = Console.ReadLine();
            int antal;
            bool lyckad = int.TryParse(buy, out antal);
            Console.WriteLine("Du måste betala " + antal * 10);
            Console.ReadLine();
        }
    }
}