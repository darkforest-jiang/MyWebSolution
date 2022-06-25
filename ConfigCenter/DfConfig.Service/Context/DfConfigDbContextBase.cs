using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DfConfig.Service.Context
{
    public class DfConfigDbContextBase : DbContext
    {
        public static string ConnStr;

        public DfConfigDbContextBase() { }

        public DfConfigDbContextBase(DbContextOptions<DfConfigMysqlDbContext> options) : base(options)
        {

        }

        public DfConfigDbContextBase(DbContextOptions<DfConfigSqlserverDbContext> options) : base(options)
        {

        }

    }
}
