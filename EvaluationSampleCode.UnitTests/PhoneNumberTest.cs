using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class PhoneNumberTest
    {
        private PhoneNumber _validPhoneNumber;
   
        [TestInitialize]
        public void Init()
        {
            _validPhoneNumber = PhoneNumber.Parse("0123456789");
        }


        [TestMethod]
        public void Parse_WithInvalidNumber_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse("123"));
        }

        [TestMethod]
        public void Parse_WithBlankNumber_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(""));
        }

        [TestMethod]
        public void ToString_WithValidNumber_ReturnsString()
        {
            Assert.AreEqual("(012)345-6789", _validPhoneNumber.ToString());

            // Rajout de commentaire pour la pull request
        }
    }
}
