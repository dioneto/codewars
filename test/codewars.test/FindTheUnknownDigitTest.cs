using codewars.dev.Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace codewars.test
{
    class FindTheUnknownDigitTest
    {
		[SetUp]
		public void Setup()
		{
		}

		[TestCase("1+1=?", 2)]
		[TestCase("123*45?=5?088", 6)]
		[TestCase("-5?*-1=5?", 0)]
		[TestCase("19--45=5?", -1)]
		[TestCase("??*??=302?", 5)]
		[TestCase("?*11=??", 2)]
		[TestCase("??+??=??", -1)]
		public void TestFindTheUnknownDigit(string value, int expected)
		{
			Assert.AreEqual(expected, FindTheUnknownDigit.solveExpression(value), string.Format("Input {0}", value));
		}
	}
}
