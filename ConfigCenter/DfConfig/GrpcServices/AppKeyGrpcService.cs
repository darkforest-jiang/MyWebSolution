using DfConfig.Model.GrpcInterfaces;

namespace DfConfig.GrpcServices
{
    public class AppKeyGrpcService : IAppKeyGrpcService
    {
        public async ValueTask GetAllAppKeys()
        {
            await ValueTask.CompletedTask;
        }
    }
}
