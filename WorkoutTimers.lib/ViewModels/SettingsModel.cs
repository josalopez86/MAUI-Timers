

using Microsoft.Maui.Devices;
using WorkoutTimers.lib.Services;

namespace WorkoutTimers.Lib.ViewModels
{
    public class SettingsModel //: INotifyPropertyChanged
    {

		string _version = null;
		IVersionInfo _versionInfo;

		public SettingsModel(IVersionInfo info)
		{
            _versionInfo = info;

        }

        public string OSVersion
		{
			get 
			{
				if (_version == null)
				{
                    _version = DeviceInfo.VersionString;

                }
				return _version; 
			}
		}

		public string UserEmail
        {
			get { return Preferences.Default.Get<string>(nameof(UserEmail), ""); }
			set { Preferences.Default.Set<string>(nameof(UserEmail), value); }
		}

        public int DefaultReps
        {
            get { return Preferences.Default.Get<int>(nameof(DefaultReps), 0); }
            set { Preferences.Default.Set<int>(nameof(DefaultReps), value); }
            //if (value != _defaultReps)
            //{
            //    OnPropertyChange(nameof(DefaultReps));
            //}
        }



        //      public event PropertyChangedEventHandler? PropertyChanged;

        //private int _defaultReps;

        //public int DefaultReps
        //      {
        //	get { return _defaultReps; }
        //	set { _defaultReps = value; 
        //		if(value != _defaultReps)
        //		{
        //			OnPropertyChange(nameof(DefaultReps));
        //		}
        //	}
        //}

        //private void OnPropertyChange(string propertyName)
        //{
        //          PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        //      }
    }
}
