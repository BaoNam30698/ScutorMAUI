using ScutorMAUI.Injectable;
using ScutorMAUI.Services;

namespace ScutorMAUI;

public partial class MainPage : ContentPage, ITransientDependency
{
	int count = 0;

	private readonly IMyService _myService;

    public MainPage(IMyService myService)
	{
		InitializeComponent();
		_myService = myService;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

        LblMessage.Text = _myService.Hello();


        SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

