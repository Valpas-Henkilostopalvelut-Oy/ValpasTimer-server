using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValpasTimer.Domain.Enums;

namespace ValpasTimer.Domain.Entities
{
    public class CustomField : BaseEntity
    {
        // Relationships
        public Guid WorkspaceId { get; set; }
        public Workspace Workspace { get; set; } = null!;
        // Properties
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public FieldType FieldType { get; set; }
        public string? Value { get; set; }
        public FieldStatus FieldStatus { get; set; }
    }
}