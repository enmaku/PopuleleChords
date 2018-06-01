using System.Collections.Generic;

namespace PopuleleChords
{
    public class Pattern
    {
        public string Name
        {
            get
            {
                string name = Root.ToString();
                if (ChordType.Contains(ChordFeatures.Flat)) name += "b";
                if (ChordType.Contains(ChordFeatures.Minor)) name += "m";
                if (ChordType.Contains(ChordFeatures.Major) && !ChordType.Contains(ChordFeatures.Flat) && ChordType.Count > 1) name += "maj";
                if (ChordType.Contains(ChordFeatures.Major) && ChordType.Contains(ChordFeatures.Flat) && ChordType.Count > 2) name += "maj";
                if (ChordType.Contains(ChordFeatures.Augmented)) name += "+";
                if (ChordType.Contains(ChordFeatures.Diminished)) name += "°";
                if (ChordType.Contains(ChordFeatures.Sixth)) name += "⁶";
                if (ChordType.Contains(ChordFeatures.Seventh)) name += "⁷";
                if (ChordType.Contains(ChordFeatures.Ninth)) name += "⁹";
                if (ChordType.Contains(ChordFeatures.Add9)) name += "add9";
                if (ChordType.Contains(ChordFeatures.Sus2)) name += "sus2";
                if (ChordType.Contains(ChordFeatures.Sus4)) name += "sus4";
                return name;
            }
        }
        public int[,] Fretboard { get; set; } = new int[4,15];
        public int FirstFret { get; set; }
        public char Root { get; set; }
        public List<ChordFeatures> ChordType { get; set; } = new List<ChordFeatures>();
    }

    public enum ChordFeatures { Flat, Major, Minor, Seventh, Augmented, Diminished, Sixth, Add9, Ninth, Sus2, Sus4 }
}
