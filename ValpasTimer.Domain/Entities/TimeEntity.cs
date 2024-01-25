using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValpasTimer.Domain.Entities
{
    public class TimeEntity : BaseEntity
    {
        // Relationships
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public Guid TaskId { get; set; }
        public Task Task { get; set; } = null!;
        // Properties
        public TimeInterval TimeInterval { get; set; } = null!;
    }
    public class TimeInterval
    {
        public Date Date { get; set; } = null!;
        public TimeOfDay Start { get; set; } = null!;
        public TimeOfDay? End { get; set; }
    }
    public class TimeOfDay
    {
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }

    }
    public class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }
}