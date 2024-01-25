using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValpasTimer.Domain.Entities
{
    public class Receipt : BaseEntity
    {
        // Relationships
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        // Properties
        public PurchaseDateTime PurchaseDateTime { get; set; } = null!;
        public string? Description { get; set; }
    }
    public class PurchaseDateTime
    {
        public Date Date { get; set; } = null!;
        public TimeOfDay Time { get; set; } = null!;
    }
}