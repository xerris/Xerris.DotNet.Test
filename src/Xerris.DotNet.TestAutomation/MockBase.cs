using System;
using Moq;

namespace Xerris.DotNet.TestAutomation
{
    public abstract class MockBase : IDisposable
    {
        private readonly MockRepository mocks;

        protected MockBase()
        {
            mocks = new MockRepository(MockBehavior.Strict);
        }

        protected Mock<T> Create<T>(MockBehavior behavior = MockBehavior.Strict) where T : class
        {
            return mocks.Create<T>(MockBehavior.Strict);
        }

        protected Mock<T> Strict<T>() where T : class
        {
            return mocks.Create<T>(MockBehavior.Strict);
        }

        protected Mock<T> Loose<T>() where T : class
        {
            return mocks.Create<T>(MockBehavior.Loose);
        }

        public virtual void Dispose()
        {
            mocks.VerifyAll();
        }
    }
}