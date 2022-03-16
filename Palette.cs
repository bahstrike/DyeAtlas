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
                DyeAtlas.ColorConversion.ColorToHSV(pe.color, out pe.h, out pe.s, out pe.v);
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

            // HSV color
            public double h, s, v;//precached for performance
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

        // cheating with statics
        public static double HueImportance = 0.0;
        public static double SaturationImportance = 0.0;
        public static double ValueImportance = 0.0;


        private void RegenerateHSVCache()
        {
            foreach (PaletteEntry pe in entries)
            {
                double aHue, aSat, aVal;
                DyeAtlas.ColorConversion.ColorToHSV(pe.color, out aHue, out aSat, out aVal);
            }
        }

        public int FindClosestIndex(Color clr, bool hsvCompare)
        {
            if (clr.A == 0)
                return 0;

            int closestIndex = -1;
            int closestDiff = 99999;
            foreach (PaletteEntry pe in entries)
            {
                int diff;

                if (hsvCompare)
                {
                    double bHue, bSat, bVal;
                    DyeAtlas.ColorConversion.ColorToHSV(clr, out bHue, out bSat, out bVal);


                    double hueDiff = DyeAtlas.AngleDiff.distance(pe.h, bHue) / 180.0;
                    double satDiff = Math.Abs(pe.s - bSat);
                    double valDiff = Math.Abs(pe.v - bVal);

#if false
                    // just use our HSV comparison directly later
                    diff = 0;

                    // weights
                    hueDiff *= HueImportance;
                    satDiff *= SaturationImportance;
                    valDiff *= ValueImportance;
#else
                    // RGB compare;  seems to be a good baseline
                    diff = Math.Abs(pe.color.R - clr.R) + Math.Abs(pe.color.G - clr.G) + Math.Abs(pe.color.B - clr.B);

                    // weights (based around 0 because we have a RGB already)
                    double weightScale = 6.0;
                    hueDiff *= HueImportance * weightScale;
                    satDiff *= SaturationImportance * weightScale;
                    valDiff *= ValueImportance * weightScale;
#endif


                    // influence with HSV diffs
                    diff += (int)Math.Round(hueDiff * 100.0) +
                        (int)Math.Round(satDiff * 100.0) +
                        (int)Math.Round(valDiff * 100.0);
                }
                else
                {
                    // RGB compare
                    diff = Math.Abs(pe.color.R - clr.R) + Math.Abs(pe.color.G - clr.G) + Math.Abs(pe.color.B - clr.B);
                }

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
