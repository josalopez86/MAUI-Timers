using System.Windows.Input;

namespace WorkoutTimers.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            NavigateToSettingsCommand = new Command(async () => {
                await DisplayAlert("Menu Item", "Settings", "OK");
                this.FlyoutIsPresented = this.FlyoutBehavior != FlyoutBehavior.Flyout;
            });

            BindingContext = this;
        }

        public ICommand NavigateToSettingsCommand { get; private set; }


    }
}
