using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValpasTimer.Domain.Entities
{
    public class UserTask
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public Guid TaskId { get; set; }
        public Task Task { get; set; } = null!;
    }
}