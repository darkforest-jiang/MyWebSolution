using DfConfig.Model.Interfaces;

namespace DfConfig.Services
{
    public class AppKeyService : IAppKeyService
    {
        public async ValueTask GetAllAppKeys()
        {
            await ValueTask.CompletedTask;
        }
    }
}
