using MultitactionCornerstoneApi.Models;
using System.Numerics;

namespace MultitactionCornerstoneApiTests
{
    /// <summary>
    /// Unit tests for the Touch model using MSTest.
    /// Tests the model for creation with correct and incorrect values.
    /// </summary>
    [TestClass]
    public class ModelTouchTest
    {
        /// <summary>
        /// Test instantiation with correct arguments.
        /// </summary>
        [TestMethod]
        public void TestNormalInitialization()
        {
            var touch = new Touch(1, 1, 1.0f, new Vector2(1.0f, 1.0f));

            Assert.AreEqual(1, touch.Id);
            Assert.AreEqual(1, touch.Age);
            Assert.AreEqual(1.0f, touch.Distance);
            Assert.AreEqual(1.0f, touch.Position.X);
            Assert.AreEqual(1.0f, touch.Position.Y);
        }

        /// <summary>
        /// Test instantiation with a negative id.
        /// Initializes the class with -1 for id.
        /// </summary>
        [TestMethod]
        public void TestNegativeId()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => new Touch(-1, 1, 1.0f, new Vector2(1.0f, 1.0f))
            );
        }

        /// <summary>
        /// Test instantiation with a negative age.
        /// Initializes the class with a -1 for age.
        /// </summary>
        [TestMethod]
        public void TestNegativeAge()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => new Touch(1, -1, 1.0f, new Vector2(1.0f, 1.0f))
            );
        }

        /// <summary>
        /// Test instantiation with a negative distance.
        /// Initializes the class with -1.0f for distance.
        /// </summary>
        [TestMethod]
        public void TestNegativeDistance()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => new Touch(1, 1, -1.0f, new Vector2(1.0f, 1.0f))
            );
        }

        /// <summary>
        /// Test instantiation with a higher value for distance.
        /// Initializes the class with 2.0f for distance.
        /// </summary>
        [TestMethod]
        public void TestGreaterThanOneDistance()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => new Touch(1, 1, 2.0f, new Vector2(1.0f, 1.0f))
            );
        }

        /// <summary>
        /// Test instantiation with a negative X-position.
        /// Initializes the class with new Vector2(-1.0f, 1.0f) for position.
        /// </summary>
        [TestMethod]
        public void TestNegativeXPosition()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => new Touch(1, 1, 1.0f, new Vector2(-1.0f, 1.0f))
            );
        }

        /// <summary>
        /// Test instantiation with a negative Y-position.
        /// Initializes the class with new Vector2(1.0f, -1.0f) for position.
        /// </summary>
        [TestMethod]
        public void TestNegativeYPosition()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => new Touch(1, 1, 1.0f, new Vector2(1.0f, -1.0f))
            );
        }
    }
}