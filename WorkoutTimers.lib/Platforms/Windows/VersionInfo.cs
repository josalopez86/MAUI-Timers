using WorkoutTimers.lib.Services;

namespace WorkoutTimers.lib
{
    // All the code in this file is only included on Windows.
    public class VersionInfo : IVersionInfo
    {
        public string GetOSVersion()
        {
            return string.Empty;
        }
    }
}
