using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class BaptizmTest
    {
        private ClergyMember _pope;
        private ClergyMember _priest;
        private ClergyMember _clergyMember;
        private ClergyMember _otherClergyMember;
        private Baptizm _baptizm;

        [TestInitialize]
        public void Init()
        {
            _priest = new ClergyMember { IsPriest = true };
            _pope = new ClergyMember { IsPope = true };
            _clergyMember = new ClergyMember();
            _otherClergyMember = new ClergyMember();
        }

        [TestMethod]
        public void CanBeBaptizedBy_Priest_ReturnsTrue ()
        {
            _baptizm = new Baptizm(_clergyMember);

            var result = _baptizm.CanBeBaptizedBy(_priest);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void CanBeBaptizedBy_Pope_ReturnsTrue()
        {
            _baptizm = new Baptizm(_clergyMember);

            var result = _baptizm.CanBeBaptizedBy(_pope);

            Assert.IsTrue(result);

        }


        [TestMethod]

        public void CanBeBaptizedBy_OtherClergyMember_ReturnsFalse()
        {
            _baptizm = new Baptizm(_clergyMember);

            var result = _baptizm.CanBeBaptizedBy(_otherClergyMember);

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void CanBeTeachedBy_clergyMember_ReturnsTrue()
        {
            _baptizm = new Baptizm(_clergyMember);

            var result = _baptizm.CanBeTeachedBy(_clergyMember);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeTeachedBy_Priest_ReturnsFalse()
        {
            _baptizm = new Baptizm(_clergyMember);

            var result = _baptizm.CanBeTeachedBy(_priest);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanBeTeachedBy_Pope_ReturnsFalse()
        {
            _baptizm = new Baptizm(_clergyMember);

            var result = _baptizm.CanBeTeachedBy(_pope);

            Assert.IsFalse(result);
        }

        [TestMethod]

        public void CanBeTeachedBy_OtherClergyMember_ReturnsFalse()
        {
            _baptizm = new Baptizm(_clergyMember);

            var result = _baptizm.CanBeTeachedBy(_otherClergyMember);

            Assert.IsFalse(result);
        }
    }
}