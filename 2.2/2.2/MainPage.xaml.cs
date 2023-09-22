using System.Windows.Input;

namespace _2._2;

public partial class MainPage : ContentPage
{
    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

	public MainPage()
    {
        InitializeComponent();
    }

	private async void visitURI(object sender, EventArgs e)
	{
		Uri url;
		switch ((sender as Button).Text)
		{
			case "Vue.js":
				url = new Uri("https://vuejs.org/tutorial/#step-1");
				break;
			case "Typescript":
				url = new Uri("https://www.w3schools.com/typescript/");
				break;
			case "SCSS":
				url = new Uri("https://www.w3schools.com/sass/");
				break;
			default:
				url = new Uri("https://www.w3schools.com/sass/");
				break;
		}

		await Browser.OpenAsync(url);
	}
	
    private async void TapGestureRecognizer_OnTapped(object sender, TappedEventArgs e)
    {
	    Uri itvisURI = new Uri("https://it-visibility.net");
	    await Browser.OpenAsync(itvisURI);
    }
}