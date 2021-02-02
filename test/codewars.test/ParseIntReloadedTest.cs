using codewars.dev.Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace codewars.test
{
    class ParseIntReloadedTest
    {
        /*
In this kata we want to convert a string into an integer. The strings simply represent the numbers in words.

Examples:

"one" => 1
"twenty" => 20
"two hundred forty-six" => 246
"seven hundred eighty-three thousand nine hundred and nineteen" => 783919
Additional Notes:

The minimum number is "zero" (inclusively)
The maximum number, which must be supported is 1 million (inclusively)
The "and" in e.g. "one hundred and twenty-four" is optional, in some cases it's present and in others it's not
All tested numbers are valid, you don't need to validate them
        */

        [SetUp]
        public void Setup()
        {
        }

		[TestCase("one", 1)]
		[TestCase("twenty", 20)]
		[TestCase("two hundred forty-six", 246)]
		[TestCase("seven hundred eighty-three thousand nine hundred and nineteen", 783919)]
		[TestCase("one million", 1000000)]
        [TestCase("eight hundred (and) thirty-four", 834)]
        [TestCase("seven hundred", 700)]
        [TestCase("five hundred (and) eighty-nine", 589)]
        [TestCase("two thousand", 2000)]
        [TestCase("one thousand (and) three", 1003)]
        [TestCase("two hundred (and) eighty-seven", 287)]
        [TestCase("eighty-one", 81)]
        public void TestTextToNumber(string value, long expected)
		{
			Assert.AreEqual(expected, ParseIntReloaded.ParseInt(value), string.Format("Input {0}", value));
		}

	}
}
