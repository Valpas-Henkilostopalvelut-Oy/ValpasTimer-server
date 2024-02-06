using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValpasTimer.Domain.Entities
{
    public class Workspace : BaseEntity
    {
        public string Name { get; set; } = null!;
        public List<WorkspaceUser>? Memberships { get; set; }
        public List<TimeEntity>? Times { get; set; }
        public CostRate? CostRate { get; set; }
        public string? Image { get; set; }

    }
    public class CostRate
    {
        public int Amount { get; set; }
        public string Currency { get; set; } = null!;
    }
}