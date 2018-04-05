using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PopuleleChords
{
    public partial class MainPage : ContentPage
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

            SKPaint frets = new SKPaint
            {
                Style = SKPaintStyle.StrokeAndFill,
                Color = Color.Black.ToSKColor(),
                StrokeWidth = 1
            };

            canvas.Clear();
            int scale = info.Width / 5;
            int string_width = scale;
            int fret_height = scale;
            int radius = scale / 3;
            const int pad = 15;

            SKPaint lines = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                StrokeWidth = 5,
                Color = Color.LightGray.ToSKColor()
            };

            // Draw the frets
            for (int j = 0; j < pattern.Fretboard.GetLength(1) + 1 || j < 4; j++)
            {
                canvas.DrawLine(
                    string_width * 0.5f,            // x0
                    (j + 1) * fret_height + pad,    // y0
                    string_width * 3.5f,            // x1
                    (j + 1) * fret_height + pad,    // y1
                    lines);                         // paint style
            }

            // Draw the strings
            lines.Color = Color.Black.ToSKColor();
            for (int i = 0; i < pattern.Fretboard.GetLength(0); i++)
                canvas.DrawLine(
                    (i + 1) * string_width - (string_width * 0.5f), // x0
                    0,                                              // y0
                    (i + 1) * string_width - (string_width * 0.5f), // x1
                    info.Height,                                    // y1
                    lines);                                         // paint style

            // Draw the notes
            for (int i = 0; i < pattern.Fretboard.GetLength(0); i++)
            {
                for (int j = 0; j < pattern.Fretboard.GetLength(1); j++)
                {
                    if (pattern.Fretboard[i, j] <= 0) continue;
                    int circle_x = (i + 1) * string_width - (int)(string_width * 0.5f);
                    int circle_y = (j + 1) * fret_height - (int)(fret_height * 0.5f) + pad;
                    canvas.DrawCircle(circle_x, circle_y, radius, frets);
                }
            }

            // Draw the nut
            lines.Color = Color.Black.ToSKColor();
            lines.StrokeWidth = 30;
            canvas.DrawLine(
                string_width * 0.5f,    // x0
                0,                      // y0
                string_width * 3.5f,    // x1
                0,                      // y1
                lines);                 // paint style
        }
    }
}
