using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant.Api.Data
{
    public class StrategySchemaModelCacheKey : IModelCacheKeyFactory
    {
        public object Create(DbContext context)
        {
            var model = new
            {
                Type = context.GetType(),
                Schema = (context as ApplicationContext)?.TenantData.TenantId
            };
            return model;
        }
    }
}
