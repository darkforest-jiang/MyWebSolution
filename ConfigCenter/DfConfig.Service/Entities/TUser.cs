using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfConfig.Service.Entities
{
    /// <summary>
    /// 账户
    /// </summary>
    public class TUser
    {
        /// <summary>
        /// 主键Id 自增
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string LoginId { get; set; }

        /// <summary>
        /// 账号密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 账号名称
        /// </summary>
        public string Name { get; set; }
    }
}
