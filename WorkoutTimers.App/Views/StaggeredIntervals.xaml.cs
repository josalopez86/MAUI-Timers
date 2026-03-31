using WorkoutTimers.Lib.ViewModels;

namespace WorkoutTimers.App.Views;

public partial class StaggeredIntervals : ContentPage
{
	public StaggeredIntervals(StaggeredIntervalsModel model)
	{
		InitializeComponent();
        BindingContext = model;
        model.RefreshIntervalsCommand.Execute(null);
    }
}