using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using StackifySupport.Authorization.Roles;
using StackifySupport.Authorization.Users;
using StackifySupport.MultiTenancy;

namespace StackifySupport.EntityFrameworkCore
{
    public class StackifySupportDbContext : AbpZeroDbContext<Tenant, Role, User, StackifySupportDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public StackifySupportDbContext(DbContextOptions<StackifySupportDbContext> options)
            : base(options)
        {
        }
    }
}
