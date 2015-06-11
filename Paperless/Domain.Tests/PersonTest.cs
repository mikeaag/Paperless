using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paperless.Domain;

namespace Paperless.Domain.Tests
{
    [TestClass]
    public class PersonTest
    {
        public PersonTest()
        {
            
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void SetName_ValidName_SetsTitleFirstNameAndLastName()
        {
            var person = new Person();
            person.SetName("Mr", "Bob", "Doctormun");
            Assert.AreEqual("Mr Bob Doctormun", person.GetFullName());
        }
    }
}
