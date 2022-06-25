using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DfConfig.Model.Interfaces
{
    [ServiceContract]
    public interface IAppKeyService
    {
        [OperationContract]
        ValueTask GetAllAppKeys();
    }
}
