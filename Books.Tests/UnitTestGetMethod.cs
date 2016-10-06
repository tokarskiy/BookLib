using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Books.Controllers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace Books.Tests
{
    [TestClass]
    public class UnitTestGetMethod
    {
        [TestMethod]
        public void Test_GetMethodReturnsRightNumberOfElements()
        {
            var controller = new SimpleBooksController();
            var jsonString = controller.Get();
            var elems = JArray.Parse(jsonString);
            Assert.AreEqual(elems.Count(), controller.Count);
        }
    }
}
