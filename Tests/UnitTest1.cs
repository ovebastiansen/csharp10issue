using Domain;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void DoesNotCompile()
        {
            IService service = new Service();

            Assert.That(() => service.DoSomething(), Throws.InstanceOf<NotImplementedException>());
        }

        [Test]
        public void CompilesIn10()
        {
            IService service = new Service();

            Assert.That((TestDelegate)(() => service.DoSomething()), Throws.InstanceOf<NotImplementedException>());
        }
    }
}