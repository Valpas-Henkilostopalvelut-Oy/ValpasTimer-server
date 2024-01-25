using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValpasTimer.Domain.Entities
{
    public class Task : BaseEntity
    {
        // Relationships
        public Guid WorkspaceId { get; set; }
        public Workspace Workspace { get; set; } = null!;
        public List<UserTask>? UserTasks { get; set; }
        public List<TimeEntity>? Times { get; set; }
        // Properties
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}