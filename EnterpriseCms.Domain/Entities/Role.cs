using System;
using System.Collections.Generic;

namespace EnterpriseCms.Domain.Entities
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSystem { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation
        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
