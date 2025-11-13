using System;

namespace EnterpriseCms.Domain.Entities
{
    public class RefreshToken
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Token { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public DateTime ExpiresAt { get; set; }
        public DateTime? RevokedAt { get; set; }
        public string RevocationReason { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation
        public virtual User User { get; set; }
    }
}
