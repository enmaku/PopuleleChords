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
                Pattern chord = (Pattern)this.FindByName<ListView>("ChordList").SelectedItem;
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

            SKPaint lines = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                StrokeWidth = 5
            };

            canvas.Clear();
            int[,] fretboard = pattern.Fretboard;
            int string_width = 25;
            int fret_height = 25;
            int radius = string_width > fret_height ? fret_height : string_width;
            radius /= 3;

            lines.Color = Color.LightGray.ToSKColor();
            for (int j = 0; j < fretboard.GetLength(1) + 1 || j < 4; j++)
            {
                canvas.DrawLine(
                    string_width / 2,
                    (j + 1) * fret_height + 15,
                    string_width * 3.5f,
                    (j + 1) * fret_height + 15,
                    lines);
            }

            lines.Color = Color.Black.ToSKColor();
            for (int i = 0; i < fretboard.GetLength(0); i++)
                canvas.DrawLine(
                    (i + 1) * string_width - (string_width / 2),
                    0, 
                    (i + 1) * string_width - (string_width / 2), 
                    info.Height, 
                    lines);

            for (int i = 0; i < fretboard.GetLength(0); i++)
            {
                for (int j = 0; j < fretboard.GetLength(1); j++)
                {
                    if (fretboard[i, j] <= 0) continue;

                    int circle_x = (i + 1) * string_width - (string_width / 2);
                    int circle_y = (j + 1) * fret_height - (fret_height / 2) + 15;
                    canvas.DrawCircle(circle_x, circle_y, radius, frets);
                }
            }
            lines.Color = Color.Black.ToSKColor();
            lines.StrokeWidth = 30;
            canvas.DrawLine(string_width / 2, 0, string_width * 3.5f, 0, lines);
        }
    }
}
