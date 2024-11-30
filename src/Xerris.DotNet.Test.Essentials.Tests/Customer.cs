using System;

namespace Xerris.DotNet.Test.Essentials.Tests
{
    public class Customer
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "Sample Customer";
    }
}