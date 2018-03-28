using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace PopuleleChords
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
		{
			InitializeComponent();
            foreach (Pattern chord in Patterns.ChordList)
                chord.FretGrid = PatternMethods.FretboardGrid(chord);
            this.FindByName<ListView>("ChordList").ItemsSource = Patterns.ChordList;
            this.FindByName<ListView>("ChordList").ItemSelected += (sender, e) => 
            {
                Pattern chord = (Pattern)this.FindByName<ListView>("ChordList").SelectedItem;
            };
        }
    }
}
