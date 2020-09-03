using codewars.dev.Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace codewars.test
{
    class SudokuSolutionValidatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Ok()
        {
            int[][] test = new int[9][];
            test[0] = new int[9] { 5, 3, 4, 6, 7, 8, 9, 1, 2 };
            test[1] = new int[9] { 6, 7, 2, 1, 9, 5, 3, 4, 8 };
            test[2] = new int[9] { 1, 9, 8, 3, 4, 2, 5, 6, 7 };
            test[3] = new int[9] { 8, 5, 9, 7, 6, 1, 4, 2, 3 };
            test[4] = new int[9] { 4, 2, 6, 8, 5, 3, 7, 9, 1 };
            test[5] = new int[9] { 7, 1, 3, 9, 2, 4, 8, 5, 6 };
            test[6] = new int[9] { 9, 6, 1, 5, 3, 7, 2, 8, 4 };
            test[7] = new int[9] { 2, 8, 7, 4, 1, 9, 6, 3, 5 };
            test[8] = new int[9] { 3, 4, 5, 2, 8, 6, 1, 7, 9 };

            Assert.AreEqual(true, SudokuSolutionValidator.ValidateSolution(test));
        }

        [Test]
        public void Test_Nok_Colunas()
        {
            int[][] test = new int[9][];
            test[0] = new int[9] { 5, 3, 4, 6, 7, 8, 9, 1, 2 };
            test[1] = new int[9] { 6, 7, 2, 1, 9, 0, 3, 4, 8 };
            test[2] = new int[9] { 1, 0, 0, 3, 4, 2, 5, 6, 0 };
            test[3] = new int[9] { 8, 5, 9, 7, 6, 1, 0, 2, 0 };
            test[4] = new int[9] { 4, 2, 6, 8, 5, 3, 7, 9, 1 };
            test[5] = new int[9] { 7, 1, 3, 9, 2, 4, 8, 5, 6 };
            test[6] = new int[9] { 9, 0, 1, 5, 3, 7, 2, 1, 4 };
            test[7] = new int[9] { 2, 8, 7, 4, 1, 9, 6, 3, 5 };
            test[8] = new int[9] { 3, 0, 0, 4, 8, 1, 1, 7, 9 };

            Assert.AreEqual(false, SudokuSolutionValidator.ValidateSolution(test));
        }

        [Test]
        public void Test_Nok_SubQuadros()
        {
            int[][] test = new int[9][];
            test[0] = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            test[1] = new int[9] { 2, 3, 1, 5, 6, 4, 8, 9, 7 };
            test[2] = new int[9] { 3, 1, 2, 6, 4, 5, 9, 7, 8 };
            test[3] = new int[9] { 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            test[4] = new int[9] { 5, 6, 4, 8, 9, 7, 2, 3, 1 };
            test[5] = new int[9] { 6, 4, 5, 9, 7, 8, 3, 1, 2 };
            test[6] = new int[9] { 7, 8, 9, 1, 2, 3, 4, 5, 6 };
            test[7] = new int[9] { 8, 9, 7, 2, 3, 1, 5, 6, 4 };
            test[8] = new int[9] { 9, 7, 8, 3, 1, 2, 6, 4, 5 };

            Assert.AreEqual(false, SudokuSolutionValidator.ValidateSolution(test));
        }
    }
}
