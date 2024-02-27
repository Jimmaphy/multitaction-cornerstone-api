using MultitactionCornerstoneApi.Models;
using System.Numerics;

namespace MultitactionCornerstoneApiTests
{
    /// <summary>
    /// Unit tests for the Hand model using MSTest.
    /// Tests the model for creation with correct and incorrect values.
    /// </summary>
    [TestClass]
    public class ModelHandTest
    {
        /// <summary>
        /// The touch variable holds a simple instance of the touch class.
        /// </summary>
        private static Touch touch = new Touch(1, 1, 1, new Vector2(1, 1));

        /// <summary>
        /// Test instantiation with correct arguments.
        /// </summary>
        [TestMethod]
        public void TestNormalInitialization()
        {
            var hand = new Hand(1, 1, [touch]);

            Assert.AreEqual(1, hand.Id);
            Assert.AreEqual(1, hand.Age);
            Assert.AreEqual(true, hand.Fingers.Contains(touch));
        }

        /// <summary>
        /// Test instantiation with a negative id.
        /// Initializes the class with -1 for id.
        /// </summary>
        [TestMethod]
        public void TestNegativeId()
        {
            Assert.ThrowsException<ArgumentException>(() => new Hand(-1, 1, [touch]));
        }

        /// <summary>
        /// Test instantiation with a negative age.
        /// Initializes the class with a -1 for age.
        /// </summary>
        [TestMethod]
        public void TestNegativeAge()
        {
            Assert.ThrowsException<ArgumentException>(() => new Hand(1, -1, [touch]));
        }

        /// <summary>
        /// Test instantiation with a null value for fingers.
        /// Initializes the class with null for fingers.
        /// </summary>
        [TestMethod]
        public void TestNullFingers()
        {
            Assert.ThrowsException<ArgumentException>(() => new Hand(1, 1, null));
        }

        /// <summary>
        /// Test instantiation with an empty list of touch points.
        /// Initializes the class with new List<Touch>() for fingers.
        /// </summary>
        [TestMethod]
        public void TestEmptyFingers()
        {
            Assert.ThrowsException<ArgumentException>(() => new Hand(1, 1, new List<Touch>()));
        }
    }
}