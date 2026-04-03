using WorkoutTimers.lib.Services;

namespace WorkoutTimers.lib
{
    // All the code in this file is only included on Android.
    public class VersionInfo : IVersionInfo
    {
        public string GetOSVersion()
        {
            return Android.OS.Build.VERSION.Release;
        }
    }
}
