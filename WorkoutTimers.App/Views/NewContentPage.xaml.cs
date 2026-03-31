namespace WorkoutTimers.App.Views;

[QueryProperty(nameof(Content), nameof(Content))]
public partial class NewContentPage : ContentPage
{
	public string Content { 
		get { return contentLabel?.Text; } 
		set { contentLabel.Text = value; } }
	public NewContentPage()
	{
		InitializeComponent();
	}
}