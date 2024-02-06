using ValpasTimer.Domain.Enums;

namespace ValpasTimer.Domain.Entities
{
    public class WorkspaceUser
    {
        public CostRate CostRate { get; set; } = null!;
        public MembershipStatus Status { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public Guid WorkspaceId { get; set; }
        public Workspace Workspace { get; set; } = null!;
    }

}