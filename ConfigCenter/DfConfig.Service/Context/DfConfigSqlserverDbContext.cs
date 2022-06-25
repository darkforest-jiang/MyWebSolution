using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfConfig.Service.Context
{
    public class DfConfigSqlserverDbContext : DfConfigDbContextBase
    {
        public DfConfigSqlserverDbContext() { }

        public DfConfigSqlserverDbContext(DbContextOptions<DfConfigSqlserverDbContext> options)
         : base(options)
        {
        }
    }
}
