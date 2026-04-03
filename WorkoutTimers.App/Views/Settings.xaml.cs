using WorkoutTimers.Lib.ViewModels;

namespace WorkoutTimers.App.Views;

//[QueryProperty(nameof(Message), nameof(Message))]
public partial class Settings : ContentPage
{
	private string _msg;
	public string Message
	{
		get { return _msg; }
		set { _msg = value;
				OnPropertyChanged(nameof(Message));
			}
	}

	public Settings(SettingsModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}

}