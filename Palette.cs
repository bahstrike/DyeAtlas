using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace DyeAtlas
{
    public class Palette
    {
        public static Palette LoadFromCSV(Stream s)
        {
            Palette pal = new Palette();

            StreamReader sr = new StreamReader(s);
            while (!sr.EndOfStream)
            {
                string[] parts = sr.ReadLine().Split(',');

                PaletteEntry pe = new PaletteEntry();
                pe.index = int.Parse(parts[0]);
                pe.name = parts[1];
                pe.color = Color.FromArgb(
                    int.Parse(parts[2].Substring(1, 2), System.Globalization.NumberStyles.HexNumber),
                    int.Parse(parts[2].Substring(3, 2), System.Globalization.NumberStyles.HexNumber),
                    int.Parse(parts[2].Substring(5, 2), System.Globalization.NumberStyles.HexNumber)
                    );
                pal.entries.Add(pe);
            }

            return pal;
        }


        public List<PaletteEntry> entries = new List<PaletteEntry>();

        public class PaletteEntry
        {
            public int index;
            public string name;
            public Color color;
        }

        public Color? Get(int index)
        {
            if (index == 0)
                return Color.FromArgb(0, 0, 0, 0);

            foreach (PaletteEntry pe in entries)
                if (pe.index == index)
                    return pe.color;

            return null;
        }

        public int FindClosestIndex(Color clr)
        {
            if (clr.A == 0)
                return 0;

            int closestIndex = -1;
            int closestDiff = 99999;
            foreach (PaletteEntry pe in entries)
            {
                int diff = Math.Abs(pe.color.R - clr.R) + Math.Abs(pe.color.G - clr.G) + Math.Abs(pe.color.B - clr.B);

                if (diff < closestDiff)
                {
                    // blacklist?
                    /*if (pe.name.Equals("magenta", StringComparison.InvariantCultureIgnoreCase) ||
                        pe.name.Equals("dark pink", StringComparison.InvariantCultureIgnoreCase) ||
                        pe.name.Equals("pink", StringComparison.InvariantCultureIgnoreCase))
                        continue;*/

                    closestDiff = diff;
                    closestIndex = pe.index;
                }
            }

            return closestIndex;
        }
    }
}
