using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Snowwhite
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            //Dictionary<string, int> colors = new Dictionary<string, int>();

            //string line;
            //while ((line = Console.ReadLine()) != "Once upon a time")
            //{
            //    string[] tokens = line
            //        .Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

            //    string dwarfName = tokens[0];
            //    string dwarfHatColor = tokens[1];
            //    int dwarfPhysics = int.Parse(tokens[2]);

            //    string currentDwarfId = $"{dwarfName} <:> {dwarfHatColor}";

            //    if (dwarfs.ContainsKey(currentDwarfId) == false)
            //    {
            //        dwarfs.Add(currentDwarfId, dwarfPhysics);

            //        if (colors.ContainsKey(dwarfHatColor) == false)
            //        {
            //            colors.Add(dwarfHatColor, 1);
            //        }
            //        else
            //        {
            //            colors[dwarfHatColor]++;
            //        }
            //    }
            //    else
            //    {
            //        int oldValue = dwarfs[currentDwarfId];
            //        if (dwarfPhysics > oldValue)
            //        {
            //            dwarfs[currentDwarfId] = dwarfPhysics;
            //        }
            //    }
            //}

            //Dictionary<string, int> sortedDwarfs = dwarfs
            //    .OrderByDescending(d => d.Value)
            //    .ThenByDescending(d => colors[d.Key.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries)[1]])
            //    .ToDictionary(x => x.Key, x => x.Value);

            //foreach (var dwarf in sortedDwarfs)
            //{
            //    string dwarfId = dwarf.Key;
            //    string[] dwarfIdTokens = dwarfId.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

            //    string dwarfName = dwarfIdTokens[0];
            //    string dwarfHatColor = dwarfIdTokens[1];

            //    int dwarfPhsyics = dwarf.Value;

            //    Console.WriteLine($"({dwarfHatColor}) {dwarfName} <-> {dwarfPhsyics}");
            //}

            Dictionary<KeyValuePair<string, string>, long> dwarfs = new Dictionary<KeyValuePair<string, string>, long>();
            Dictionary<string, int> colors = new Dictionary<string, int>();

            string line = Console.ReadLine();
            while (line != "Once upon a time")
            {
                string[] tokens = line.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

                string dwarfName = tokens[0];
                string dwarfHatColor = tokens[1];
                long dwarfPhysics = long.Parse(tokens[2]);

                KeyValuePair<string, string> dwarf = new KeyValuePair<string, string>(dwarfName, dwarfHatColor);

                if (!dwarfs.ContainsKey(dwarf))
                {
                    dwarfs.Add(dwarf, dwarfPhysics);
                    if (!colors.ContainsKey(dwarfHatColor))
                    {
                        colors.Add(dwarfHatColor, 0);
                    }
                    colors[dwarfHatColor]++;
                }
                else
                {
                    if (dwarfPhysics > dwarfs[dwarf])
                    {
                        dwarfs[dwarf] = dwarfPhysics;
                    }
                }
            }

            Dictionary<KeyValuePair<string, string>, long> sorted = dwarfs.OrderByDescending(d => d.Value)
                .ThenByDescending(d => colors[d.Key.Value])
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var dwarf in sorted)
            {
                string hatColor = dwarf.Key.Value;
                string name = dwarf.Key.Key;
                long physics = dwarf.Value;

                Console.WriteLine($"({hatColor}) {name} <-> {physics}");
            }
        }
    }
}
