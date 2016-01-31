using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace CSharp
{
    [TestFixture]
    public class MyTests3
    {
        public MyTests3()
        {
            GlobalSettings.AddFormatter(
                new ValueFormatterFactory(
                    _ => new ValueFormatter(
                        x => $"[v] = {x}")));
        }

        [Test]
        public void MyCoolTest()
        {
            Assert.AreEqual(1, 2);
        }
    }
}
