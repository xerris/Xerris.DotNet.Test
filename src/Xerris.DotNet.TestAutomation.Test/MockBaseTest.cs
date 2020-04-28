using System.Threading.Tasks;
using Moq;
using Xunit;

namespace Xerris.DotNet.TestAutomation.Test
{
    public class MockBaseTest : MockBase
    {
        [Fact]
        public async Task Go()
        {
            var service = Create<IService>(); //defaults to Strict mock
            var client = new Client(service.Object);
            service.Setup(x => x.Go()).Returns(Task.CompletedTask);
            await client.Go();
        }

        [Fact]
        public async Task GoStrict()
        {
            var service = Strict<IService>(); //defaults to Strict mock
            var client = new Client(service.Object);
            var request = new Request {Id = 1};
            service.Setup(x => x.Go(request)).Returns(Task.CompletedTask);
            await client.Go(request);
        }

        [Fact]
        public async Task GoLoose()
        {
            var service = Loose<IService>(); //defaults to Strict mock
            var client = new Client(service.Object);
            var request = new Request {Id = 1};
            service.Setup(x => x.Go(request)).Returns(Task.CompletedTask);
            await client.Go(request);
        }
    }
}