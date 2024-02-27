namespace MultitactionCornerstoneApi.Models
{
    /// <summary>
    /// A Hand is a collection of touch points that are related to each other.
    /// Each touch point is represented by a Touch object, and represents a finger on the screen.
    /// </summary>
    /// <param name="age">The total time the hand has been present in seconds</param>
    /// <param name="fingers">The collection of touch points related to this hand</param>
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

        public Hand(int id, int age, List<Touch> fingers)
        {
            if (id < 0) {
                throw new ArgumentException("Id cannot be negative");
            }

            if (age < 0) {
                throw new ArgumentException("Age cannot be negative");
            }

            if (fingers == null || fingers.Count == 0)
            {
                throw new ArgumentException("Fingers cannot be null or empty");
            }

            Id = id;
            Age = age;
            Fingers = fingers;
        }
    }
}
