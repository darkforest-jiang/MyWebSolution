using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfConfig.Service.Entities
{
    /// <summary>
    /// 应用拥有的资源
    /// </summary>
    public class TAppOwnRes
    {
        /// <summary>
        /// 主键Id 自增
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 应用Key
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// 运行环境
        /// </summary>
        public string RuntimeEnv { get; set; }

        /// <summary>
        /// 应用拥有资源Id
        /// </summary>
        public int AppResId { get; set; }
    }
}
