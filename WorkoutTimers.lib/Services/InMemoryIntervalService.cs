using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutTimers.Lib.ViewModels;

namespace WorkoutTimers.Lib.Services
{
    public class InMemoryIntervalService : IIntervalService
    {
        private static List<RegularIntervalModel> _intervals = new List<RegularIntervalModel>();
        private static List<StaggeredIntervalModel> _staggereds = new List<StaggeredIntervalModel>();

        static InMemoryIntervalService()
        {
            _intervals.Add(new RegularIntervalModel
            {
                Name = "Example fifth",
                Duration = TimeSpan.FromMinutes(1),
                Repetitions = 5
            });
            _intervals.Add(new RegularIntervalModel
            {
                Name = "Example fourth",
                Duration = TimeSpan.FromMinutes(15),
                Repetitions = 4
            });
            _intervals.Add(new RegularIntervalModel
            {
                Name = "Example third",
                Duration = TimeSpan.FromMinutes(6),
                Repetitions = 3
            });
            _intervals.Add(new RegularIntervalModel
            {
                Name = "Example second",
                Duration = TimeSpan.FromMinutes(18),
                Repetitions = 2
            });

            _staggereds.Add(new StaggeredIntervalModel
            {
                Name = "Staggered 1",
                Repetitions = 1,
                Durations = new ObservableCollection<IntervalDuration>
                {
                    new IntervalDuration {Duration = TimeSpan.FromMinutes(1) },
                    new IntervalDuration {Duration = TimeSpan.FromSeconds(30) },
                    new IntervalDuration {Duration = TimeSpan.FromMinutes(1) }
                }
            });
            _staggereds.Add(new StaggeredIntervalModel
            {
                Name = "Staggered 2",
                Repetitions = 2,
                Durations = new ObservableCollection<IntervalDuration>
                {
                    new IntervalDuration {Duration = TimeSpan.FromMinutes(2) },
                    new IntervalDuration {Duration = TimeSpan.FromSeconds(32) },
                    new IntervalDuration {Duration = TimeSpan.FromMinutes(2)
            }
                }
            });
            _staggereds.Add(new StaggeredIntervalModel
            {
                Name = "Staggered 3",
                Repetitions = 3,
                Durations = new ObservableCollection<IntervalDuration>
                {
                    new IntervalDuration {Duration = TimeSpan.FromMinutes(3) },
                    new IntervalDuration {Duration = TimeSpan.FromSeconds(33) },
                    new IntervalDuration {Duration = TimeSpan.FromMinutes(3) }
                }
            });
        }
        public async Task AddRegularIntervalModel(RegularIntervalModel model)
        {
            _intervals.Add(model);
        }

        public async Task AddStaggeredIntervalModel(StaggeredIntervalModel model)
        {
            _staggereds.Add(model);
        }

        public async Task<List<RegularIntervalModel>> GetRegularIntervalModelsAsync()
        {
            return await Task.FromResult(_intervals);
        }

        public async Task<List<StaggeredIntervalModel>> GetStaggeredIntervalModelsAsync()
        {
            return await Task.FromResult(_staggereds);
        }
    }
}
