using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfConfig.Service.Entities
{
    /// <summary>
    /// 字典
    /// </summary>
    public class TDic
    {
        /// <summary>
        /// 主键Id 自增
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 字典类型
        /// </summary>
        public string DicType { get; set; }

        /// <summary>
        /// 字典编码
        /// </summary>
        public string DicCode { get; set; }

        /// <summary>
        /// 字典名称
        /// </summary>
        public string? DicName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string? Memo { get; set; }
    }
}
