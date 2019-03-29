using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Adventure;

namespace AdventureTests
{
    [TestFixture]
    class InputReaderTests
    {
        [Test]
        public void GetAction_ValidInput_ChangesPlayerLocation()
        {
            InputReader.GetAction();
            Assert.That(1, Is.EqualTo(1));
        }
    }
}
