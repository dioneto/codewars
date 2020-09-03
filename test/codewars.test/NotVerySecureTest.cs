using codewars.dev.Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace codewars.test
{
    class NotVerySecureTest
    {
        /*
         * In this example you have to validate if a user input string is alphanumeric. 
         * The given string is not nil/null/NULL/None, so you don't have to check that.
         The string has the following conditions to be alphanumeric:
            - At least one character ("" is not valid)
            - Allowed characters are uppercase / lowercase latin letters and digits from 0 to 9
            - No whitespaces / underscore
        */

        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test_Alfa()
        {
            Assert.AreEqual(true, NotVerySecure.Alphanumeric("Mazinkaiser"));
        }
        [Test]
        public void Test_Underline()
        {
            Assert.AreEqual(false, NotVerySecure.Alphanumeric("hello world_"));
        }
        [Test]
        public void Test_AlfaNum()
        {
            Assert.AreEqual(true, NotVerySecure.Alphanumeric("PassW0rd"));
        }
        [Test]
        public void Test_Espacos()
        {
            Assert.AreEqual(false, NotVerySecure.Alphanumeric("     "));
        }
        [Test]
        public void Test_CaracteresInvalidos()
        {
            Assert.AreEqual(false, NotVerySecure.Alphanumeric("&)))((("));
        }
        
    }
}
