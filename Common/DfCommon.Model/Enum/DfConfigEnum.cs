using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfCommon.Model.Enum
{
    public class DfConfigEnum
    {
        /// <summary>
        /// 资源文件类型 
        /// </summary>
        public enum FileType
        {
            /// <summary>
            /// 要加入应用appsetting中的
            /// </summary>
            Appsetting,
            /// <summary>
            /// 文件
            /// </summary>
            File
        }
    }
}
