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
            Assert.ThrowsException<ArgumentException>(
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
            Assert.ThrowsException<ArgumentException>(
                () => new Touch(1, -1, 1.0f, new Vector2(1.0f, 1.0f))
            );
        }

        /// <summary>
        /// Test instantiation with a null value for fingers.
        /// Initializes the class with null for fingers.
        /// </summary>
        [TestMethod]
        public void TestNegativeDistance()
        {
            Assert.ThrowsException<ArgumentException>(
                () => new Touch(1, 1, -1.0f, new Vector2(1.0f, 1.0f))
            );
        }

        /// <summary>
        /// Test instantiation with an empty list of touch points.
        /// Initializes the class with new List<Touch>() for fingers.
        /// </summary>
        [TestMethod]
        public void TestNegativeXPosition()
        {
            Assert.ThrowsException<ArgumentException>(
                () => new Touch(1, 1, 1.0f, new Vector2(-1.0f, 1.0f))
            );
        }

        // Test instantiation with an empty list of touch points.
        /// Initializes the class with new List<Touch>() for fingers.
        /// </summary>
        [TestMethod]
        public void TestNegativeYPosition()
        {
            Assert.ThrowsException<ArgumentException>(
                () => new Touch(1, 1, 1.0f, new Vector2(1.0f, -1.0f))
            );
        }
    }
}