using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DfCommon.Model.RequestResponse
{
    /// <summary>
    /// 请求
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    [DataContract]
    public class Rr<TResult>
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [DataMember(Order = 1)]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        [DataMember(Order = 2)]
        public string? Message { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [DataMember(Order = 3)]
        public TResult? Result { get; set; }
    }
}
