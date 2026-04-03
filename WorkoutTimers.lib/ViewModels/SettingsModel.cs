

using System.ComponentModel;

namespace WorkoutTimers.Lib.ViewModels
{
    public class SettingsModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

		private int _defaultReps;

		public int DefaultReps
        {
			get { return _defaultReps; }
			set { _defaultReps = value; 
				if(value != _defaultReps)
				{
					OnPropertyChange(nameof(DefaultReps));
				}
			}
		}

		private void OnPropertyChange(string propertyName)
		{
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
	}
}
