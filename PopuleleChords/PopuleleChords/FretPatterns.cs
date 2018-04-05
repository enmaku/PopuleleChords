﻿using System.Collections.Generic;
using SkiaSharp.Views.Forms;

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
                if (ChordType.Contains(ChordFeatures.Major) && !ChordType.Contains(ChordFeatures.Flat) && ChordType.Count > 1) name += "M";
                if (ChordType.Contains(ChordFeatures.Major) && ChordType.Contains(ChordFeatures.Flat) && ChordType.Count > 2) name += "M";
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

        public string Notes { get; set; } = string.Empty;
        public int[,] Fretboard { get; set; } = new int[4,15];
        public SKCanvasView FretImage { get; set; }
        public int FirstFret { get; set; }
        public char Root { get; set; }
        public List<ChordFeatures> ChordType { get; set; } = new List<ChordFeatures>();
    }

    public enum ChordFeatures { Flat, Major, Minor, Seventh, Augmented, Diminished, Sixth, Add9, Ninth, Sus2, Sus4 }

    public static class Patterns
    {
        public static List<Pattern> ChordList = new List<Pattern>
        {
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major },
                Fretboard = new [,]
                {
                    { 0, 1 },
                    { 1, 0 },
                    { 0, 0 },
                    { 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor },
                Fretboard = new [,]
                {
                    { 0, 1 },
                    { 0, 0 },
                    { 0, 0 },
                    { 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Augmented },
                Fretboard = new [,]
                {
                    { 0, 1, 0, 0 },
                    { 1, 0, 0, 0 },
                    { 1, 0, 0, 0 },
                    { 0, 0, 0, 1 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Diminished },
                Fretboard = new [,]
                {
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh },
                Fretboard = new [,]
                {
                    { 0 },
                    { 1 },
                    { 0 },
                    { 0 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Seventh },
                Fretboard = new [,]
                {
                    { 0 },
                    { 0 },
                    { 0 },
                    { 0 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major, ChordFeatures.Seventh },
                Fretboard = new [,]
                {
                    { 1 },
                    { 1 },
                    { 0 },
                    { 0 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sixth },
                Fretboard = new [,]
                {
                    { 0, 1 },
                    { 1, 0 },
                    { 0, 1 },
                    { 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Sixth },
                Fretboard = new [,]
                {
                    { 0, 1 },
                    { 0, 0 },
                    { 0, 1 },
                    { 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Add9 },
                Fretboard = new [,]
                {
                    { 0, 1 },
                    { 1, 0 },
                    { 0, 0 },
                    { 0, 1 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Ninth },
                Fretboard = new [,]
                {
                    { 0, 1 },
                    { 0, 0 },
                    { 0, 0 },
                    { 0, 1 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Ninth },
                Fretboard = new [,]
                {
                    { 0, 0 },
                    { 1, 0 },
                    { 0, 0 },
                    { 0, 1 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sus2 },
                Fretboard = new [,]
                {
                    { 0, 1, 0, 0, 0 },
                    { 0, 1, 0, 1, 0 },
                    { 0, 1, 0, 0, 1 },
                    { 0, 1, 0, 0, 0 }
                },
                FirstFret = 1
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sus4 },
                Fretboard = new [,]
                {
                    { 0, 1 },
                    { 0, 1 },
                    { 0, 0 },
                    { 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh, ChordFeatures.Sus4 },
                Fretboard = new [,]
                {
                    { 0, 0 },
                    { 0, 1 },
                    { 0, 0 },
                    { 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Major },
                Fretboard = new [,]
                {
                    { 1, 0, 1 },
                    { 1, 1, 0 },
                    { 1, 0, 0 },
                    { 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor },
                Fretboard = new [,]
                {
                    { 1, 0, 1 },
                    { 1, 0, 0 },
                    { 1, 0, 0 },
                    { 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Augmented },
                Fretboard = new [,]
                {
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Diminished },
                Fretboard = new [,]
                {
                    { 0, 0, 1 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Seventh },
                Fretboard = new [,]
                {
                    { 1, 0, 0 },
                    { 1, 0, 0 },
                    { 1, 1, 0 },
                    { 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor, ChordFeatures.Seventh },
                Fretboard = new [,]
                {
                    { 1, 0, 0 },
                    { 1, 0, 0 },
                    { 1, 0, 0 },
                    { 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Major, ChordFeatures.Seventh },
                Fretboard = new [,]
                {
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Sixth },
                Fretboard = new [,]
                {
                    { 1, 0 },
                    { 1, 0 },
                    { 0, 1 },
                    { 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor, ChordFeatures.Sixth },
                Fretboard = new [,]
                {
                    { 1, 0, 1 },
                    { 1, 0, 0 },
                    { 1, 0, 1 },
                    { 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Add9 },
                Fretboard = new [,]
                {
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 1 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor, ChordFeatures.Ninth },
                Fretboard = new [,]
                {
                    { 0, 0, 1 },
                    { 1, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 1 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Ninth },
                Fretboard = new [,]
                {
                    { 0, 0, 1, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 1, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Sus2 },
                Fretboard = new [,]
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Sus4 },
                Fretboard = new [,]
                {
                    { 1, 0, 1 },
                    { 1, 0, 1 },
                    { 1, 0, 0 },
                    { 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Seventh, ChordFeatures.Sus4 },
                Fretboard = new [,]
                {
                    { 1, 0, 0 },
                    { 1, 0, 1 },
                    { 1, 0, 0 },
                    { 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major },
                Fretboard = new[,]
                {
                    { 0, 1, 0, 1 },
                    { 0, 1, 1, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor },
                Fretboard = new[,]
                {
                    { 0, 1, 0, 1 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Augmented },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 1 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Diminished },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 1 },
                    { 0, 1, 0, 0 },
                    { 1, 0, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 1, 0 },
                    { 0, 1, 1 },
                    { 0, 1, 0 },
                    { 0, 1, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 1 },
                    { 0, 1 },
                    { 0, 1 },
                    { 0, 1 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor },
                Fretboard = new[,]
                {
                    { 0, 1, 0, 1 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 1 },
                    { 0, 0, 1, 0 },
                    { 0, 1, 0, 0 },
                    { 1, 0, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sixth },
                Fretboard = new[,]
                {
                    { 1, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 1, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Sixth },
                Fretboard = new[,]
                {
                    { 1, 0 },
                    { 0, 1 },
                    { 0, 1 },
                    { 0, 1 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Add9 },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 1 },
                    { 0, 0, 1, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 0, 0, 1 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Ninth },
                Fretboard = new[,]
                {
                    { 0, 1 },
                    { 1, 0 },
                    { 0, 0 },
                    { 0, 1 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Ninth },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 1, 0 },
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 1, 0 }
                },
                FirstFret = 2
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sus2 },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 1 },
                    { 1, 0, 0, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sus4 },
                Fretboard = new[,]
                {
                    { 0, 1, 0, 1 },
                    { 0, 1, 0, 1 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh, ChordFeatures.Sus4 },
                Fretboard = new[,]
                {
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 1 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                }
            },
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                }
            },
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 0 },
                    { 0, 0 },
                    { 0, 0 },
                    { 0, 1 },
                }
            },
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0 },
                    { 0 },
                    { 0 },
                    { 1 },
                }
            },
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Major },
                Fretboard = new[,]
                {
                    { 1, 0, 0, 0 },
                    { 1, 0, 0, 0 },
                    { 1, 0, 0, 0 },
                    { 1, 0, 0, 1 }
                }
            },
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor },
                Fretboard = new[,]
                {
                    { 1, 0, 0, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 1 }
                }
            },
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major },
                Fretboard = new[,]
                {
                    { 0, 1 },
                    { 0, 1 },
                    { 0, 1 },
                    { 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor },
                Fretboard = new[,]
                {
                    { 0, 1 },
                    { 0, 1 },
                    { 1, 0 },
                    { 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 1 }
                }
            },
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Major },
                Fretboard = new[,]
                {
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor },
                Fretboard = new[,]
                {
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 1 },
                    { 0, 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 1, 0 },
                    { 0, 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 }
                }
            },
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major },
                Fretboard = new[,]
                {
                    { 0, 1 },
                    { 0, 0 },
                    { 1, 0 },
                    { 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor },
                Fretboard = new[,]
                {
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 1 }
                }
            },
            new Pattern
            {
                Root = 'G',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Major },
                Fretboard = new[,]
                {
                    { 0, 0, 1 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'G',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor },
                Fretboard = new[,]
                {
                    { 0, 1 },
                    { 1, 0 },
                    { 0, 1 },
                    { 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'G',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 }
                }
            },
            new Pattern
            {
                Root = 'G',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor },
                Fretboard = new[,]
                {
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                    { 1, 0, 0 }
                }
            },
            new Pattern
            {
                Root = 'G',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 }
                }
            },
            new Pattern
            {
                Root = 'G',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Major },
                Fretboard = new[,]
                {
                    { 1, 0, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 1, 0 }
                }
            },
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 1 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 1, 0, 0 }
                }
            }
        };
    }
}
