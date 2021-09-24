using Domain;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            IService service = new Service();

            Assert.That(() => service.DoSomething(), Throws.InstanceOf<NotImplementedException>());
        }
    }
}