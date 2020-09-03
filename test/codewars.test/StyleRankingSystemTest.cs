using codewars.Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace codewars.test
{
    class StyleRankingSystemTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void RankInicial()
        {
            User user = new User();
            Assert.AreEqual(-8, user.rank);
        }
        [Test]
        public void ProgressoInicial()
        {
            User user = new User();
            Assert.AreEqual(0, user.progress);
        }
        [Test]
        public void ProgressoParaIgual()
        {
            User user = new User();
            user.incProgress(-8);
            Assert.AreEqual(3, user.progress);
        }
        [Test]
        public void ProgressoParaMaior1()
        {
            User user = new User();
            user.incProgress(-7);
            Assert.AreEqual(10, user.progress);
        }
        [Test]
        public void ProgressoParaMaior2()
        {
            User user = new User();
            user.incProgress(-6);
            Assert.AreEqual(40, user.progress);
        }
        [Test]
        public void ProgressoParaMaior3()
        {
            User user = new User();
            user.incProgress(-5);
            Assert.AreEqual(90, user.progress);
        }
        [Test]
        public void ProgressoParaMaior4()
        {
            User user = new User();
            user.incProgress(-4);
            Assert.AreEqual(60, user.progress);
            Assert.AreEqual(-7, user.rank);
        }
    }
}
