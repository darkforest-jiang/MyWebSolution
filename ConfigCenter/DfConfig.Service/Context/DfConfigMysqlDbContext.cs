using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfConfig.Service.Context
{
    public class DfConfigMysqlDbContext : DfConfigDbContextBase
    {
        public DfConfigMysqlDbContext() { }

        public DfConfigMysqlDbContext(DbContextOptions<DfConfigMysqlDbContext> options)
          : base(options)
        {
        }
    }
}
