using System.Windows.Input;
using WorkoutTimers.App.Views;

namespace WorkoutTimers.App
{
    public partial class AppShell : Shell
    {
        public ICommand NavigateToSettingsCommand { get; private set; }
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Settings", typeof(Settings));
            Routing.RegisterRoute("NewRegularInterval", typeof(NewRegularInterval));
            Routing.RegisterRoute("NewStaggeredInterval", typeof(NewStaggeredInterval));

            NavigateToSettingsCommand = new Command(async () =>
            {
                //await DisplayAlert("Menu Item", "Settings", "OK");
                var dict = new Dictionary<string, object> {
                        { "Message", "The power of Navigation!!" }
                    };

                await GoToAsync("Settings", dict);
                this.FlyoutIsPresented = this.FlyoutBehavior != FlyoutBehavior.Flyout;
            });

            BindingContext = this;
        }
    }
}
