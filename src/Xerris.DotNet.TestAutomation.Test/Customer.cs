using System;

namespace Xerris.DotNet.TestAutomation.Test
{
    public class Customer
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "Sample Customer";
    }
}