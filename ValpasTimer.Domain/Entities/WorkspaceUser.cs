using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValpasTimer.Domain.Entities
{
    public class WorkspaceUser
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public Guid WorkspaceId { get; set; }
        public Workspace Workspace { get; set; } = null!;
    }
}