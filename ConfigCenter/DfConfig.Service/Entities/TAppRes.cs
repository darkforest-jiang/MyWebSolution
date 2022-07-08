using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfConfig.Service.Entities
{
    /// <summary>
    /// 应用资源
    /// </summary>
    public class TAppRes
    {
        /// <summary>
        /// 主键Id 自增
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 运行环境
        /// </summary>
        public string RuntimeEnv { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        public string ResType { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        public string ResName { get; set; }

        /// <summary>
        /// 资源值
        /// </summary>
        public string ResValue { get; set; }

        public string FileType { get; set; }

        /// <summary>
        /// 文件类文件名
        /// </summary>
        public string? FileName { get; set; }
    }
}
