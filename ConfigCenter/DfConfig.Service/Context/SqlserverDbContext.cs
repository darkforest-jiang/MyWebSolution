using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfConfig.Service.Entities;

namespace DfConfig.Service.Context
{
    
    public class SqlserverDbContext : DbContextBase
    {
        public SqlserverDbContext() { }

        public SqlserverDbContext(DbContextOptions<SqlserverDbContext> options)
         : base(options)
        {
        }

        public virtual DbSet<TAppKey> TAppKeys { get; set; } = null!;
        public virtual DbSet<TAppOwnRes> TAppOwnRes { get; set; } = null!;
        public virtual DbSet<TAppRes> TAppRes { get; set; } = null!;
        public virtual DbSet<TAppsetting> TAppsettings { get; set; } = null!;
        public virtual DbSet<TDic> TDics { get; set; } = null!;
        public virtual DbSet<TUser> TUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
