using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfHelper.EF;
using Microsoft.EntityFrameworkCore;

namespace DfConfig.Service.Context
{
    public class DbContextBase : DbContext
    {
        /// <summary>
        /// 数据库链接字符串
        /// mysql: server=localhost;database=dfconfig;port=3306;user=root;password=root;charset=utf8mb4;sslmode=none;maxpoolsize=1000;
        /// sqlserver: 
        /// oracle: 
        /// </summary>
        public static string ConnStr;

        /// <summary>
        /// 数据库类型
        /// </summary>
        public static DbEnum DbType;

        public DbContextBase() { }

        public DbContextBase(DbContextOptions<MysqlDbContext> options) : base(options)
        {

        }

        public DbContextBase(DbContextOptions<SqlserverDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// 获取对应数据库Context
        /// </summary>
        /// <returns></returns>
        public static DbContextBase GetContext()
        {
            switch (DbType)
            {
                case DbEnum.Sqlserver:
                    return new SqlserverDbContext();
                case DbEnum.Mysql:
                    return new MysqlDbContext();
                default:
                    return new MysqlDbContext();
            }
        }

    }
}
