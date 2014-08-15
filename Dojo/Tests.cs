using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.That(Class1.Foo(), Is.EqualTo(1));
        }
    }
}
