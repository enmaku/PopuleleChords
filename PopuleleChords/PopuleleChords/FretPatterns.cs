using System.Collections.Generic;
using Xamarin.Forms;

namespace PopuleleChords
{
    public class Pattern
    {
        public string Name { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public int[,] Fretboard { get; set; } = new int[4,15];
        public Grid FretGrid { get; set; }
    }

    public static class Patterns
    {
        public static List<Pattern> ChordList = new List<Pattern>()
        {
            new Pattern
            {
                Name = "A",
                Notes = "A major",
                Fretboard = new int[4,2]
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
                Fretboard = new int[4,2]
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
                Fretboard = new int[4,2]
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
                Fretboard = new int[4,3]
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
                Fretboard = new int[4,3]
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
                Fretboard = new int[4,4]
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
                Fretboard = new int[4,4]
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
                Fretboard = new int[4,4]
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
                Fretboard = new int[4,3]
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
                Fretboard = new int[4,3]
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
                Fretboard = new int[4,2]
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
                Fretboard = new int[4,1]
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
                Fretboard = new int[4,4]
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
                Fretboard = new int[4,4]
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
                Fretboard = new int[4,2]
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
                Fretboard = new int[4,2]
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
                Fretboard = new int[4,3]
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
                Fretboard = new int[4,3]
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
                Fretboard = new int[4,3]
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
                Fretboard = new int[4,4]
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
                Fretboard = new int[4,4]
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
                Fretboard = new int[4,3]
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
                Fretboard = new int[4,2]
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
                Fretboard = new int[4,3]
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
                Fretboard = new int[4,3]
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
                Fretboard = new int[4,2]
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
                Fretboard = new int[4,3]
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
                Fretboard = new int[4,3]
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
                Fretboard = new int[4,3]
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
                Fretboard = new int[4,3]
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
                Fretboard = new int[4,4]
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
                Fretboard = new int[4,4]
                {
                    { 0, 0, 0, 1 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 1, 0, 0 }
                }
            }
        };
    }

    public class PatternMethods
    {
        public static Grid FretboardGrid(Pattern pattern)
        {
            Grid chordGrid = new Grid { RowSpacing = -1, ColumnSpacing = -1 };
            try
            {
                int j = 0;

                for (int i = 0; i < pattern.Fretboard.GetLength(0); i++)
                    chordGrid.Children.Add(new Image { Source = "topfret.png" }, i, 0);
                for (int i = 0; i < pattern.Fretboard.GetLength(0); i++)
                    for (j = 0; j < pattern.Fretboard.GetLength(1); j++)
                        if (pattern.Fretboard[i, j] > 0)
                            chordGrid.Children.Add(new Image { Source = "pegged.png" }, i, j+1);
                        else
                            chordGrid.Children.Add(new Image { Source = "open.png" }, i, j+1);
                for (int i = 0; i < pattern.Fretboard.GetLength(0); i++)
                    chordGrid.Children.Add(new Image { Source = "open.png", Margin = 0 }, i, pattern.Fretboard.GetLength(1)+1);
                while (j < 4)
                {
                    for (int i = 0; i < pattern.Fretboard.GetLength(0); i++)
                        chordGrid.Children.Add(new Image { Source = "open.png", Margin = 0 }, i, j + 1);
                    j++;
                }
            }
            catch { }
            return chordGrid;
        }
    }
}
