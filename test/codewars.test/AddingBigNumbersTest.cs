using codewars.dev.Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace codewars.test
{
    class AddingBigNumbersTest
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
        public void Test_0()
        {
            Assert.AreEqual("444", AddingBigNumbers.Add("123", "321"));
        }
        [Test]
        public void Test_1()
        {
            Assert.AreEqual("110", AddingBigNumbers.Add("11", "99"));
        }
        [Test]
        public void Test_2()
        {
            Assert.AreEqual("3333333333222", AddingBigNumbers.Add("1111111111222", "2222222222222"));
        }


    }
}
