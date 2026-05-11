using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Tests
{
    [TestClass()]
    
    public class ThermostatTests
    {
        public const int TempMin = 5;
    
        public const int Max = 35;
    
        public const int validex = 15;
    
        public const int defaults  = 20;

        Thermostat creevalide()
        {
            return new Thermostat(validex);
        }
        [TestMethod()]
        public void ThermostataugementaitTest()
        {
            Thermostat thermostat = creevalide();

            thermostat.AugmenterTemperature();
            Assert.AreEqual(validex +1 , thermostat.Temperature);

        }

        [TestMethod()]
        public void ThermostatConstSansParamTest()
        {
          
            Thermostat unThermostat = new Thermostat();

            Assert.AreEqual(defaults,unThermostat.Temperature);

        }

        [TestMethod()]
        public void ThermostatTemp_hors_limite_sup_Test()
        {

          
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
             {
                 Thermostat thermostat = new Thermostat(36);

                 thermostat.AugmenterTemperature();
                 Assert.AreEqual(Max , thermostat.Temperature +1);


             }
             );

        }
        [TestMethod()]
        public void ThermostatTemp_horsest()
        {


            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Thermostat unThermostat = new Thermostat(4);


            }
             );

        }
    }
}