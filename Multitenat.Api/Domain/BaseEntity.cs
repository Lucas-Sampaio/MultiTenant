﻿namespace Multitenant.Api.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string TenantId { get; set; }
    }
}
