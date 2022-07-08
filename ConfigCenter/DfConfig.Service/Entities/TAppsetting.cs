using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfConfig.Service.Entities
{
    /// <summary>
    /// 应用配置文件
    /// </summary>
    public class TAppsetting
    {
        /// <summary>
        /// 应用Key
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// 运行环境
        /// </summary>
        public string RuntimeEnv { get; set; }

        /// <summary>
        /// Appsetting
        /// </summary>
        public string Appsetting { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }
    }
}
