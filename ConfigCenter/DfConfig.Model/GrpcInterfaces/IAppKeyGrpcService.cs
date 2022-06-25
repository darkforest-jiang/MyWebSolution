using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DfConfig.Model.GrpcInterfaces
{
    [ServiceContract]
    public interface IAppKeyGrpcService
    {
        [OperationContract]
        ValueTask GetAllAppKeys();
    }
}
