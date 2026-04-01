using System.Collections.ObjectModel;

namespace WorkoutTimers.Lib.ViewModels
{
    public class StaggeredIntervalModel
    {
        public string Name { get; set; }

        public ObservableCollection<IntervalDuration> Durations { get; set; } = new ObservableCollection<IntervalDuration>();

        public TimeSpan TotalDuration { get {
            return new TimeSpan(Durations.Sum(d=>d.Duration.Ticks));
            } 
        }
        public int Repetitions { get; set; } = 0;
    }

    public class IntervalDuration
    {
        public TimeSpan Duration { get; set; }
    }
}
