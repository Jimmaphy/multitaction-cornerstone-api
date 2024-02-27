namespace MultitactionCornerstoneApi.Models
{
    /// <summary>
    /// A Hand is a collection of touch points that are related to each other.
    /// Each touch point is represented by a Touch object, and represents a finger on the screen.
    /// </summary>
    public class Hand
    {
        /// <summary>
        /// The unique identifier for this hand.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// The total time the hand has been present in seconds.
        /// </summary>
        public int Age { get; private set; }

        /// <summary>
        /// The collection of touch points related to this hand.
        /// </summary>
        public List<Touch> Fingers { get; private set; }

        /// <summary>
        /// Create an instance of the Hand class, providing id, age and fingers.
        /// The id and age should be positive.
        /// Fingers should be an instance of a list that contains items.
        /// </summary>
        /// <param name="id">The unique identifier for this hand</param>
        /// <param name="age">The total time the hand has been present in seconds</param>
        /// <param name="fingers">The collection of touch points related to this hand</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Hand(int id, int age, List<Touch> fingers)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(id);
            ArgumentOutOfRangeException.ThrowIfNegative(age);
            ArgumentNullException.ThrowIfNull(fingers);

            if (fingers.Count == 0)
            {
                throw new ArgumentException("Fingers cannot be null or empty");
            }

            Id = id;
            Age = age;
            Fingers = fingers;
        }
    }
}
