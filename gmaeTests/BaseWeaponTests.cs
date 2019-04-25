using Microsoft.VisualStudio.TestTools.UnitTesting;
using gmae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gmae.Tests
{
    [TestClass()]
    public class BaseWeaponTests
    {
        [TestMethod()]
        public void RandomAttactValueTest_應回傳20()
        {
            var weapon = new 倚天劍(new DefualtRandomStub());
            var excepct = 20;
            var result  = weapon.RandomAttactValue();
            Assert.AreEqual(excepct, result);
        }

        [TestMethod()]
        public void RandomAttactValueTest_有冰屬性及傷害20()
        {
            var weapon = new 倚天劍(new DefualtRandomStub());
            var excepct = new AttactOTD { Attribute = AttactAttribute.冰凍, AttactValue = 20, IsLunch = true };
            var result = weapon.RandomAttactValue();
            
            Assert.AreEqual(excepct, result);
        }

    }
}