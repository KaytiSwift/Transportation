using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Test
{
    [TestFixture]
    class TranspoTests
    {
        [Test]
        public void GetMake()
        {
            //arrange
            TransPo testTranspo = new TransPo();

            //action
            testTranspo.GetMake = "Ford";
            string response = testTranspo.GetMake;

            //assert
            Assert.That(response, Is.EqualTo("Ford"));
        }

        [Test]
        public void GetModel()
        {
            TransPo testTranspo = new TransPo();

            testTranspo.GetModel = "Bronco";
            string response = testTranspo.GetModel;

            Assert.That(response, Is.EqualTo("Bronco"));
        }

        [Test]
        public void GetYear()
        {
            TransPo testTranspo = new TransPo();

            testTranspo.GetYear = "1965";
            string response = testTranspo.GetYear;

            Assert.That(response, Is.EqualTo("1965"));
        }

        [Test]
        public void GetNumWheels()
        {
            TransPo testTranspo = new TransPo();

            testTranspo.GetNumWheels = "4";
            string response = testTranspo.GetNumWheels;

            Assert.That(response, Is.EqualTo("4"));
        }

        [Test]
        public void GetColor()
        {
            TransPo testTranspo = new TransPo();

            testTranspo.GetColor = "black";
            string response = testTranspo.GetColor;

            Assert.That(response, Is.EqualTo("black"));
        }

        [Test]
        public void GetEngineSize()
        {
            TransPo testTranspo = new TransPo();

            testTranspo.GetEngineSize = "v6";
            string response = testTranspo.GetEngineSize;

            Assert.That(response, Is.EqualTo("v6"));
        }

        [Test]
        public void GetMPH()
        {
            TransPo testTranspo = new TransPo();
            
            int response = testTranspo.GetMPH(55);

            Assert.That(response, Is.EqualTo(55));
        }

        [Test]
        public void GetMPG()
        {
            TransPo testTranspo = new TransPo();

            int response = testTranspo.GetMPG(55, 11);

            Assert.That(response, Is.EqualTo(605));
        }

        [Test]
        public void GetWear()
        {
            TransPo testTranspo = new TransPo();

            string response = testTranspo.GetWear(0,0,0); 

            Assert.That(response, Is.EqualTo("Invalid Entry"));
        }

        [Test]
        public void GetWear_If_Miles_div_heat_Less_Than_50_percent_tread_return_Unsafe()
        {
            TransPo testTranspo = new TransPo();

            string response = testTranspo.GetWear(20, 85, 32);

            Assert.That(response, Is.EqualTo("UnSafe"));
        }

        [Test]
        public void GetWear_If_Miles_div_heat_Greater_Than_50_percent_tread_return_Safe()
        {
            TransPo testTranspo = new TransPo();

            string response = testTranspo.GetWear(1500, 85, 32);

            Assert.That(response, Is.EqualTo("Safe"));
        }
    }
}
