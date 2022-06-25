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
    /// <typeparam name="TRequestParm"></typeparam>
    [DataContract]
    public class Rp<TRequestParm>
    {
        [DataMember(Order = 1)]
        public TRequestParm RequestParm { get; set; }
    }
}
