using Foundation;
using WorkoutTimers.lib.Services;

namespace WorkoutTimers.lib
{
    // All the code in this file is only included on iOS.
    public class VersionInfo : IVersionInfo
    {
        public string GetOSVersion()
        {
            return NSProcessInfo.ProcessInfo.OperatingSystemName;
        }
    }
}
