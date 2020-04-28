using System.Threading.Tasks;

namespace Xerris.DotNet.TestAutomation.Test
{
    public interface IService
    {
        Task Go();
        Task Go(Request request);
    }
}