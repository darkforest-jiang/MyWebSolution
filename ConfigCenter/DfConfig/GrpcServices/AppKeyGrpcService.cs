using DfConfig.Model.GrpcInterfaces;
using DfConfig.Service;
using DfConfig.Service.Entities;
using DfConfig.Service.Context;
using DfHelper.EF.Base;

namespace DfConfig.GrpcServices
{
    public class AppKeyGrpcService : IAppKeyGrpcService
    {
        private readonly IBaseService<DfConfigDbContextBase> _baseService;

        public AppKeyGrpcService()
        {

        }

        public async ValueTask GetAllAppKeys()
        {
            await ValueTask.CompletedTask;
        }
    }
}
