using WorkoutTimers.Lib.ViewModels;

namespace WorkoutTimers.App.Views;

public partial class NewStaggeredInterval : ContentPage
{
	public NewStaggeredInterval(NewStaggeredIntervalModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}