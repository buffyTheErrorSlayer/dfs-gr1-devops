using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class HtmlFormatHelperTest
    {
        private HtmlFormatHelper _htmlFormatHelper;

        [TestInitialize]
        public void Init()
        {
            _htmlFormatHelper = new HtmlFormatHelper();
        }

        [TestMethod]
        public void GetStrongFormat_WhenCalled_EncloseWithStrongHtmlElement()
        {
            var result = _htmlFormatHelper.GetStrongFormat("Bonjour");

            Assert.AreEqual("<strong>Bonjour</strong>", result);
        }

        [TestMethod]
        public void GetItalicFormat_WhenCalled_EncloseWithItalicHtmlElement()
        {
            var result = _htmlFormatHelper.GetItalicFormat("Bonsoir");

            Assert.AreEqual("<i>Bonsoir</i>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_WithEmptyList_ReturnsEmptyHtmlElement()
        {
            var result = _htmlFormatHelper.GetFormattedListElements(
                new List<string>()
            );

            Assert.IsTrue(result.StartsWith("<ul>"));
            Assert.IsTrue(result.EndsWith("</ul>"));
            Assert.IsFalse(result.Contains("<li>"));
            Assert.IsFalse(result.Contains("</li>"));
        }

        [TestMethod]
        public void GetFormattedListElements_WithElements_ReturnsCompleteListOfHtmlELements()
        {
            var result = _htmlFormatHelper.GetFormattedListElements(
                new List<string>
                {
                    "Bonjour",
                    "Bonsoir"
                }
            );

            Assert.IsTrue(result.StartsWith("<ul>"));
            Assert.IsTrue(result.EndsWith("</ul>"));
            Assert.AreEqual(2, result.Split("<li>").Length - 1);
            Assert.AreEqual(2, result.Split("</li>").Length - 1);
            Assert.IsTrue(result.Contains("Bonjour"));
            Assert.IsTrue(result.Contains("Bonsoir"));
        }
    }
}
