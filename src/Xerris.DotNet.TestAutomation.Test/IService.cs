using System;
using System.Threading.Tasks;

namespace Xerris.DotNet.TestAutomation.Test
{
    public interface IService
    {
        Task Go();
        Task Go(Request request);
    }

    public class Service : IService
    {
        public Task Go()
        {
            return Task.CompletedTask;
        }

        public Task Go(Request request)
        {
            return Task.CompletedTask;
        }

        public virtual Task<Customer> GetCustomer(Request request)
        {
            throw new Exception("should be mocked in the Partial Mock Test");
        }
    }
}