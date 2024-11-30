using System.Threading.Tasks;

namespace Xerris.DotNet.TestAutomation.Test
{
    public class Client(IService service)
    {
        public async Task Go()
            => await service.Go();

        public async Task Go(Request request)
            => await service.Go(request);
    }
}