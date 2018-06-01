using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PopuleleChords
{
    public partial class MainPage
    {
        public MainPage()
		{
			InitializeComponent();
            this.FindByName<ListView>("ChordList").ItemsSource = Patterns.ChordList;
            this.FindByName<ListView>("ChordList").ItemSelected += (sender, e) => 
            {
                // Pattern chord = (Pattern)this.FindByName<ListView>("ChordList").SelectedItem;
            };
        }

        private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;
            SKCanvasView canvasView = (SKCanvasView) sender;
            Pattern pattern = (Pattern) canvasView.BindingContext;

            canvas.Clear();
            int diagramsize = pattern.Fretboard.GetLength(1) - pattern.FirstFret + 1;
            diagramsize = diagramsize > 5 ? diagramsize : 5;
            int scale = info.Width / diagramsize;
            int scalecenter = (int) (scale * 0.5f);
            int neckright = (int) (scale * 3.5f);
            int radius = (int)(scale * 0.4f);
            int firstfret = pattern.FirstFret;
            int numfrets = pattern.Fretboard.GetLength(1);
            int numstrings = pattern.Fretboard.GetLength(0);
            const int pad = 15;
            int i, j;

            SKPaint notes = new SKPaint
            {
                Style = SKPaintStyle.StrokeAndFill,
                Color = Color.Black.ToSKColor(),
                StrokeWidth = 1,
                TextSize = scale
            };
            SKPaint lines = new SKPaint
            {
                Style = SKPaintStyle.StrokeAndFill,
                StrokeWidth = 5,
                Color = Color.LightGray.ToSKColor()
            };

            // Draw the frets
            for (j = firstfret; j < numfrets + 1 || j < 4; j++)
            {
                int fretheight = (j - pattern.FirstFret + 1) * scale + pad;
                canvas.DrawLine(scalecenter, fretheight, neckright, fretheight, lines);
            }

            // Draw the strings
            lines.Color = Color.Black.ToSKColor();
            for (i = 0; i < numstrings; i++)
            {
                int stringpos = (i + 1) * scale - scalecenter;
                canvas.DrawLine(stringpos, 0, stringpos, info.Height, lines);
            }

            // Draw the notes
            for (i = 0; i < numstrings; i++)
            {
                for (j = firstfret; j < numfrets; j++)
                {
                    if (pattern.Fretboard[i, j] <= 0) continue;
                    int x = (i + 1) * scale - scalecenter;
                    int y = (j - pattern.FirstFret + 1) * scale - scalecenter + pad;
                    canvas.DrawCircle(x, y, radius, notes);
                }
            }

            // Draw the nut
            lines.Color = Color.Black.ToSKColor();
            lines.StrokeWidth = pad * 2;
            canvas.DrawLine(scalecenter, 0, neckright, 0, lines);

            // Draw the first fret number, if any
            if (firstfret > 0)
                canvas.DrawText( $"{firstfret + 1}", 4 * scale, scale - scalecenter + (int)(pad * 1.5f), notes);
        }
    }
}
