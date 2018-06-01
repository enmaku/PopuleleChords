using System.Collections.Generic;

namespace PopuleleChords
{
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
            }, // A
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
            }, // Am
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
            }, // A+
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
            }, // Ao
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
            }, // A7
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
            }, // Am7
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
            }, // AM7
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
            }, // A6
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
            }, // Am6
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
            }, // Aadd9
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
            }, // Am9
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
            }, // A9
            new Pattern
            {
                Root = 'A',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sus2 },
                Fretboard = new [,]
                {
                    { 0, 1, 0, 0, 0 },
                    { 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 1 },
                    { 0, 1, 0, 0, 0 }
                },
                FirstFret = 1
            }, // Asus2
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
            }, // Asus4
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
            }, // A7sus4
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Major },
                Fretboard = new [,]
                {
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 1, 0, 0 }
                }
            }, // Bb
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor },
                Fretboard = new [,]
                {
                    { 0, 0, 1 },
                    { 1, 0, 0 },
                    { 1, 0, 0 },
                    { 1, 0, 0 }
                }
            }, // Bbm
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
            }, // Bb+
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
            }, // Bbo
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Seventh },
                Fretboard = new [,]
                {
                    { 1, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 }
                }
            }, // Bb7
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
            }, // Bbm7
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
            }, // BbM7
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
            }, // Bb6
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor, ChordFeatures.Sixth },
                Fretboard = new [,]
                {
                    { 0, 0, 1 },
                    { 1, 0, 0 },
                    { 0, 0, 1 },
                    { 1, 0, 0 }
                }
            }, // Bbm6
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
            }, // Bbadd9
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
            }, // Bbm9
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
            }, // Bb9
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
            }, // Bbsus2
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Sus4 },
                Fretboard = new [,]
                {
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 1, 0, 0 },
                    { 1, 0, 0 }
                }
            }, // Bbsus4
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Seventh, ChordFeatures.Sus4 },
                Fretboard = new [,]
                {
                    { 1, 0, 0 },
                    { 0, 0, 1 },
                    { 1, 0, 0 },
                    { 1, 0, 0 }
                }
            }, // Bb7sus4
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 1 },
                    { 0, 0, 1, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            }, // B
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 1 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            }, // Bm
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
            }, // B+
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
            }, // Bo
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 1, 0 }
                }
            }, // B7
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
            }, // Bm7
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
            }, // BM7
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
            }, // B6
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
            }, // Bm6
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
            }, // Badd9
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
            }, // Bm9
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
            }, // B9
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
            }, // Bsus2
            new Pattern
            {
                Root = 'B',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sus4 },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 1 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            }, // Bsus4
            new Pattern
        {
            Root = 'B',
            ChordType = new List<ChordFeatures> { ChordFeatures.Seventh, ChordFeatures.Sus4 },
            Fretboard = new[,]
            {
                { 0, 1, 0, 0 },
                { 0, 0, 0, 1 },
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 }
            }
        }, // B7sus4
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 }
                }
            }, // C
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 0, 0, 1 }
                }
            }, // Cm
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Augmented },
                Fretboard = new[,]
                {
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 0, 1 }
                }
            }, // C+
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Diminished },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 }
                }
            }, // Co
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0 },
                    { 0 },
                    { 0 },
                    { 1 }
                }
            }, // C7
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 0, 0, 1 }
                }
            }, // Cm7
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 0 },
                    { 0, 0 },
                    { 0, 0 },
                    { 0, 1 }
                }
            }, // CM7
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sixth },
                Fretboard = new[,]
                {
                    { 0 },
                    { 0 },
                    { 0 },
                    { 0 }
                }
            }, // C6
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Sixth },
                Fretboard = new[,]
                {
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 0, 0, 1 }
                }
            }, // Cm6
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Add9 },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 }
                }
            }, // Cadd9
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Ninth },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 0, 1 },
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 1 }
                },
                FirstFret = 2
            }, // Cm9
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Ninth },
                Fretboard = new[,]
                {
                    { 0, 0 },
                    { 0, 1 },
                    { 0, 0 },
                    { 1, 0 }
                }
            }, // C9
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sus2 },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                    { 0, 0, 1 }
                }
            }, // Csus2
            new Pattern
            {
                Root = 'C',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sus4 },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 1 }
                }
            }, // Csus4
            new Pattern
        {
            Root = 'C',
            ChordType = new List<ChordFeatures> { ChordFeatures.Seventh, ChordFeatures.Sus4 },
            Fretboard = new[,]
            {
                { 0 },
                { 0 },
                { 1 },
                { 1 }
            }
        }, // C7sus4
            new Pattern
        {
            Root = 'D',
            ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Major },
            Fretboard = new[,]
            {
                { 1, 0, 0, 0 },
                { 1, 0, 0, 0 },
                { 1, 0, 0, 0 },
                { 0, 0, 0, 1 }
            }
            }, // Db
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
            }, // Dbm
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Augmented },
                Fretboard = new[,]
                {
                    { 0, 1 },
                    { 1, 0 },
                    { 1, 0 },
                    { 0, 0 }
                }
            }, // Db+
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Diminished },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 0 },
                    { 1, 0, 0, 0 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 1 }
                }
            }, // Dbo
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 1, 0 },
                    { 1, 0 },
                    { 1, 0 },
                    { 0, 1 }
                }
            }, // Db7
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 1, 0 },
                    { 1, 0 },
                    { 0, 0 },
                    { 0, 1 }
                }
            }, // Dbm7
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Major, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 1, 0, 0 },
                    { 1, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 1 }
                }
            }, // DbM7
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Sixth },
                Fretboard = new[,]
                {
                    { 1 },
                    { 1 },
                    { 1 },
                    { 1 }
                }
            }, // Db6
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor, ChordFeatures.Sixth },
                Fretboard = new[,]
                {
                    { 1 },
                    { 0 },
                    { 1 },
                    { 1 }
                }
            }, // Dbm6
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Add9 },
                Fretboard = new[,]
                {
                    { 1, 0, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 1, 0, 0, 0 },
                    { 0, 0, 0, 1 }
                }
            }, // Dbadd9
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor, ChordFeatures.Ninth },
                Fretboard = new[,]
                {
                    { 1, 0, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 1 }
                }
            }, // Dbm9
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Ninth },
                Fretboard = new[,]
                {
                    { 1, 0, 0 },
                    { 1, 0, 1 },
                    { 1, 0, 0 },
                    { 1, 1, 0 }
                }
            }, // Db9
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Sus2 },
                Fretboard = new[,]
                {
                    { 1, 0, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 1 }
                }
            }, // Dbsus2
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Sus4 },
                Fretboard = new[,]
                {
                    { 1, 0, 0, 0 },
                    { 1, 0, 0, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 0, 0, 1 }
                }
            }, // Dbsus4
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Seventh, ChordFeatures.Sus2 },
                Fretboard = new[,]
                {
                    { 1, 0 },
                    { 1, 0 },
                    { 0, 1 },
                    { 0, 1 }
                }
            }, // Db7sus2
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
            }, // D
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
            }, // Dm
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Augmented },
                Fretboard = new[,]
                {
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 }
                }
            }, // D+
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Diminished },
                Fretboard = new[,]
                {
                    { 1, 0 },
                    { 0, 1 },
                    { 1, 0 },
                    { 0, 0 }
                }
            }, // Do
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 1 }
                }
            }, // D7
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 1 }
                }
            }, // Dm7
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 0, 0, 1 }
                }
            }, // DM7
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sixth },
                Fretboard = new[,]
                {
                    { 0, 1 },
                    { 0, 1 },
                    { 0, 1 },
                    { 0, 1 }
                }
            }, // D6
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Sixth },
                Fretboard = new[,]
                {
                    { 0, 1 },
                    { 0, 1 },
                    { 1, 0 },
                    { 0, 1 }
                }
            }, // Dm6
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Add9 },
                Fretboard = new[,]
                {
                    { 0, 1, 0, 0, 0 },
                    { 0, 0, 0, 1, 0 },
                    { 0, 1, 0, 0, 0 },
                    { 0, 0, 0, 0, 1 }
                },
                FirstFret = 1
            }, // Dadd9
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Ninth },
                Fretboard = new[,]
                {
                    { 0, 1, 0, 0, 0 },
                    { 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1 }
                },
                FirstFret = 1
            }, // Dm9
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Ninth },
                Fretboard = new[,]
                {
                    { 0, 1, 0, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 1, 0, 0 },
                    { 0, 0, 1, 0 }
                }
            }, // D9
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sus2 },
                Fretboard = new[,]
                {
                    { 0, 1 },
                    { 0, 1 },
                    { 0, 0 },
                    { 0, 0 }
                }
            }, // Dsus2
            new Pattern
            {
                Root = 'D',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sus4 },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                    { 0, 0, 0 }
                }
            }, // Dsus4
            new Pattern
        {
            Root = 'D',
            ChordType = new List<ChordFeatures> { ChordFeatures.Seventh, ChordFeatures.Sus4 },
            Fretboard = new[,]
            {
                { 0, 1, 0 },
                { 0, 1, 0 },
                { 0, 0, 1 },
                { 0, 0, 1 }
            }
        }, // D7sus4
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Major },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 1, 0, 0 }
                }
            }, // Eb
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
            }, // Ebm
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Augmented },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 0, 1, 0 }
                }
            }, // Eb+
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Diminished },
                Fretboard = new[,]
                {
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 0 }
                }
            }, // Ebo
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 }
                }
            }, // Eb7
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 0, 0, 1 }
                }
            }, // Ebm7
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Major, ChordFeatures.Seventh },
                FirstFret = 2,
                Fretboard = new[,]
                {
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 1 }
                }
            }, // Ebmaj7
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Sixth },
                Fretboard = new[,]
                {
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 0, 0, 1 }
                }
            }, // Eb6
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor, ChordFeatures.Sixth },
                Fretboard = new[,]
                {
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 }
                }
            }, // Ebm6
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Add9 },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 1, 0, 0 },
                    { 1, 0, 0 }
                }
            }, // Ebadd9
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Minor, ChordFeatures.Ninth },
                FirstFret = 2,
                Fretboard = new[,]
                {
                    { 0, 0, 1, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 1 }
                }
            }, // Ebm9
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Ninth },
                Fretboard = new[,]
                {
                    { 0 },
                    { 1 },
                    { 1 },
                    { 1 }
                }
            }, // Eb9
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Sus2 },
                Fretboard = new[,]
                {
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 1 }
                }
            }, // Ebsus2
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Sus4 },
                Fretboard = new[,]
                {
                    { 1, 0, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 },
                    { 1, 0, 0, 0 }
                }
            }, // Ebsus4
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Flat, ChordFeatures.Seventh, ChordFeatures.Sus4 },
                Fretboard = new[,]
                {
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 1 }
                }
            }, // Eb7sus4
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major },
                Fretboard = new[,]
                {
                    { 1, 0, 0, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            }, // E
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
            }, // Em
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Augmented },
                Fretboard = new[,]
                {
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 }
                }
            }, // E+
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Diminished },
                Fretboard = new[,]
                {
                    { 0 },
                    { 1 },
                    { 0 },
                    { 1 }
                }
            }, // Eo
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 1, 0 },
                    { 0, 1 },
                    { 0, 0 },
                    { 0, 1 }
                }
            }, // E7
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 0, 0, 1 }
                }
            }, // Em7
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major, ChordFeatures.Seventh },
                FirstFret = 2,
                Fretboard = new[,]
                {
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 1 }
                }
            }, // Emaj7
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sixth },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 1 }
                }
            }, // E6
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Sixth },
                Fretboard = new[,]
                {
                    { 0, 0 },
                    { 1, 0 },
                    { 0, 0 },
                    { 0, 1 }
                }
            }, // Em6
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Add9 },
                Fretboard = new[,]
                {
                    { 1, 0, 0, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            }, // Eadd9
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Ninth },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            }, // Em9
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Ninth },
                Fretboard = new[,]
                {
                    { 1, 0 },
                    { 0, 1 },
                    { 0, 1 },
                    { 0, 1 }
                }
            }, // E9
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sus2 },
                Fretboard = new[,]
                {
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 1 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 }
                }
            }, // Esus2
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sus4 },
                Fretboard = new[,]
                {
                    { 1, 0, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 },
                    { 1, 0, 0, 0 }
                }
            }, // Esus4
            new Pattern
            {
                Root = 'E',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh, ChordFeatures.Sus4 },
                Fretboard = new[,]
                {
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 0, 1 }
                }
            }, // E7sus4
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
            }, // F
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
            }, // Fm
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Augmented },
                Fretboard = new[,]
                {
                    { 0, 1 },
                    { 1, 0 },
                    { 1, 0 },
                    { 0, 0 }
                }
            }, // F+
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Diminished },
                Fretboard = new[,]
                {
                    { 1, 0 },
                    { 0, 1 },
                    { 1, 0 },
                    { 0, 1 }
                }
            }, // Fo
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                    { 1, 0, 0 },
                    { 0, 0, 1 }
                }
            }, // F7
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 1, 0, 0 },
                    { 0, 0, 1 },
                    { 1, 0, 0 },
                    { 0, 0, 1 }
                }
            }, // Fm7
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Major, ChordFeatures.Seventh },
                Fretboard = new[,]
                {
                    { 0, 1, 0, 0 },
                    { 0, 0, 0, 1 },
                    { 1, 0, 0, 0 },
                    { 0, 0, 1, 0 }
                }
            }, // Fmaj7
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sixth },
                Fretboard = new[,]
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 1 }
                }
            }, // F6
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Sixth },
                Fretboard = new[,]
                {
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 1 }
                }
            }, // Fm6
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Add9 },
                Fretboard = new[,]
                {
                    { 0 },
                    { 0 },
                    { 1 },
                    { 0 }
                }
            }, // Fadd9
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Minor, ChordFeatures.Ninth },
                FirstFret = 2,
                Fretboard = new[,]
                {
                    { 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 1, 0 },
                    { 0, 0, 1, 0, 0 }
                }
            }, // Fm9
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Ninth },
                Fretboard = new[,]
                {
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 0, 0, 1 }
                }
            }, // F9
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sus2 },
                Fretboard = new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 1 }
                }
            }, // Fsus2
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Sus4 },
                Fretboard = new[,]
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 1, 0, 0 }
                }
            }, // Fsus4
            new Pattern
            {
                Root = 'F',
                ChordType = new List<ChordFeatures> { ChordFeatures.Seventh, ChordFeatures.Sus4 },
                FirstFret = 4,
                Fretboard = new[,]
                {
                    { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 1 }
                }
            }, // F7sus4
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
            }
        };
    }
}
