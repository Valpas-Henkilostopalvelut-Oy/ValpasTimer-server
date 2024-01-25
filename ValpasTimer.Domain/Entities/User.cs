using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValpasTimer.Domain.Entities
{
    public class User : BaseEntity
    {
        // Relationships
        public List<TimeEntity>? Times { get; set; }
        public List<WorkspaceUser>? WorkspaceUsers { get; set; }
        public List<Receipt>? Receipts { get; set; }
        public List<Worktravel>? Worktravels { get; set; }
        public List<UserTask>? UserTasks { get; set; }
        // Properties
        public TimeEntity? activeTime { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public byte[] Salt { get; set; } = null!;
        public Profile Profile { get; set; } = null!;
    }
    public class Profile
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Nationality { get; set; }
        public string? IBAN { get; set; }
        public string? IdNumber { get; set; }
    }
}