using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Test
{
    [TestFixture]
    class TruckTest
    {
        [Test]
        public void Create_Truck()
        {
            Truck testTruck = new Truck();
            testTruck.GetMake = "Ford";
            string response = testTruck.GetMake;

            Assert.That(response, Is.EqualTo("Ford"));
        }
    }
}
