using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elementary_Task_2;

namespace EnvelopeUnitTest
{
    [TestClass]
    public class EnvelopeTest
    {
        [TestMethod]
        [DataRow(8, 8, 8, 8)]
        public void BoardCorrectBuild(int height, int width, int expectedheight, int expectedwidth)
        {
            //Arrange

            //Act
            Envelope envelope = Envelope.EnvelopeInitialize(height, width);

            //Assert
            Assert.IsTrue((expectedheight == envelope.Height)
                && (expectedwidth == envelope.Width));
        }

        [TestMethod]
        [DataRow(-3, 2)]
        [DataRow(0, 5)]
        [ExpectedException(typeof(ArgumentException))]
        public void BoardBuild_ExceptionThrow(int height, int width)
        {
            //Arrange

            //Act
            Envelope envelope = Envelope.EnvelopeInitialize(height, width);

            //Assert
        }

        [TestMethod]
        [DataRow(11, 7, 4, 6, -1)]
        [DataRow(6, 3, 11, 8,  1)]
        [DataRow(10, 10, 10, 10, -1)]
        public void TestRectangleCompareTo_Correct(int firstEnvelopeHeight, int firstEnvelopeWidth,
            int secondEnvelopeHeight, int secondEnvelopeWidth, int expected)
        {
            Envelope firstRectangle = Envelope.EnvelopeInitialize(firstEnvelopeHeight, firstEnvelopeWidth);
            Envelope secondRectangle = Envelope.EnvelopeInitialize(secondEnvelopeHeight, secondEnvelopeWidth);
            int actual = firstRectangle.CompareTo(secondRectangle);

            Assert.AreEqual(expected, actual);
        }
    }
}
