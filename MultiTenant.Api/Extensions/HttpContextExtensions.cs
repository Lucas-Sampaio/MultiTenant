﻿using Microsoft.AspNetCore.Http;

namespace MultiTenant.Api.Extensions
{
    public static class HttpContextExtensions
    {
        public static string GetTenantId(this HttpContext httpContext)
        {
            var tenant = httpContext.Request.Path.Value.Split('/', System.StringSplitOptions.RemoveEmptyEntries)[0];

            return tenant;
        }
    }
}
