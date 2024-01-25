using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValpasTimer.Domain.Entities
{
    public class Workspace : BaseEntity
    {
        public string Name { get; set; } = null!;
        public List<WorkspaceUser>? WorkspaceUsers { get; set; } 
    }
}