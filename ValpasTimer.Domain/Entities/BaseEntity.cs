using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValpasTimer.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int Version { get; set; }
    }
}