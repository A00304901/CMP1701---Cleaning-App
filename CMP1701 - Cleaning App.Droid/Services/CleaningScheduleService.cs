using System.Collections.Generic;
using System.Threading.Tasks;
using CMP1701___Cleaning_App.Droid.Models;

namespace CMP1701___Cleaning_App.Services
{
    public interface ICleaningScheduleService
    {
        Task<List<CleaningSchedule>> GetSchedulesAsync();
        Task SaveScheduleAsync(CleaningSchedule schedule);
    }

    public class CleaningScheduleService : ICleaningScheduleService
    {
        public Task<List<CleaningSchedule>> GetSchedulesAsync()
        {
            // Simulate fetching data
            var schedules = new List<CleaningSchedule>
            {
                new CleaningSchedule { ScheduleId = 1, RoomId = 101, StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(1), Frequency = "Daily", IsActive = true },
                new CleaningSchedule { ScheduleId = 2, RoomId = 102, StartTime = DateTime.Now.AddHours(2), EndTime = DateTime.Now.AddHours(3), Frequency = "Weekly", IsActive = true }
            };
            return Task.FromResult(schedules);
        }

        public Task SaveScheduleAsync(CleaningSchedule schedule)
        {
            // Simulate saving data
            return Task.CompletedTask;
        }
    }
}
