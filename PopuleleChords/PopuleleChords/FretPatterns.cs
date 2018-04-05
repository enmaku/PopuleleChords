using System.Collections.Generic;
using SkiaSharp.Views.Forms;

namespace PopuleleChords
{
    public class Pattern
    {
        public string Name { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public int[,] Fretboard { get; set; } = new int[4,15];
        public SKCanvasView FretImage { get; set; }
    }

    public static class Patterns
    {
        public static List<Pattern> ChordList = new List<Pattern>()
        {
            new Pattern
            {
                Name = "A",
                Notes = "A major",
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
                Name = "Am",
                Notes = "A minor",
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
                Name = "A7",
                Notes = "A seventh",
                Fretboard = new [,]
                {
                    { 0, 0 },
                    { 1, 0 },
                    { 0, 0 },
                    { 0, 0 }
                }
            },
            new Pattern
            {
                Name = "A#/Bb",
                Notes = "A sharp / B flat major",
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
                Name = "A#m/Bbm",
                Notes = "A sharp / B flat major",
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
                Name = "B",
                Notes = "B major",
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
                Name = "Bm",
                Notes = "B minor",
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
                Name = "B7",
                Notes = "B seventh",
                Fretboard = new[,]
                {
                    { 0, 1, 0, 0 },
                    { 0, 1, 1, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            },
            new Pattern
            {
                Name = "C",
                Notes = "C major",
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
                Name = "Cm",
                Notes = "C minor",
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
                Name = "Cmaj7",
                Notes = "C major seventh",
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
                Name = "C7",
                Notes = "C seventh",
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
                Name = "C#",
                Notes = "C sharp",
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
                Name = "C#m",
                Notes = "C sharp minor",
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
                Name = "D",
                Notes = "D major",
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
                Name = "Dm",
                Notes = "D minor",
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
                Name = "D7",
                Notes = "D seventh",
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
                Name = "D#/Eb",
                Notes = "D sharp / E flat",
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
                Name = "D#m/Ebm",
                Notes = "D sharp / E flat minor",
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
                Name = "E",
                Notes = "E major",
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
                Name = "Em",
                Notes = "E minor",
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
                Name = "E7",
                Notes = "E seventh",
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
                Name = "F",
                Notes = "F major",
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
                Name = "Fm",
                Notes = "F minor",
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
                Name = "F#/Gb",
                Notes = "F sharp / G flat",
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
                Name = "F#m/Gbm",
                Notes = "F sharp / G flat minor",
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
                Name = "G",
                Notes = "G major",
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
                Name = "Gm",
                Notes = "G minor",
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
                Name = "G7",
                Notes = "G seventh",
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
                Name = "Gmaj7",
                Notes = "G major seventh",
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
                Name = "G#/Ab",
                Notes = "G sharp / A flat",
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
                Name = "G#m/Abm",
                Notes = "G sharp / A flat",
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
