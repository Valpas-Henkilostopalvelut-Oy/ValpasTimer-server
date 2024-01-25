using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValpasTimer.Domain.Entities
{
    public class Worktravel : BaseEntity
    {
        // Relationships
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        // Properties
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DepartureDateTime DepartureDateTime { get; set; } = null!;
        public ReturnDateTime ReturnDateTime { get; set; } = null!;
        public List<Receipt>? Receipts { get; set; }
    }
    public class DepartureDateTime
    {
        public Date Date { get; set; } = null!;
        public TimeOfDay Time { get; set; } = null!;
    }
    public class ReturnDateTime
    {
        public Date Date { get; set; } = null!;
        public TimeOfDay Time { get; set; } = null!;
    }
}