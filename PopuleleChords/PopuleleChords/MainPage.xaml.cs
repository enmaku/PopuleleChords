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
            this.FindByName<ListView>("ChordList").ItemsSource = ChordData.ChordList;
            this.FindByName<ListView>("ChordList").ItemSelected += (sender, e) => 
            {
                Chord chord = (Chord)this.FindByName<ListView>("ChordList").SelectedItem;
            };
        }
    }
}
