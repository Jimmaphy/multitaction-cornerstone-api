namespace MultitactionCornerstoneApi.Models
{
    /// <summary>
    /// A Hand is a collection of touch points that are related to each other.
    /// Each touch point is represented by a Touch object, and represents a finger on the screen.
    /// </summary>
    /// <param name="age">The total time the hand has been present in seconds</param>
    /// <param name="fingers">The collection of touch points related to this hand</param>
    public class Hand(int id, int age, List<Touch> fingers)
    {
        /// <summary>
        /// The unique identifier for this hand.
        /// </summary>
        private int Id { get; } = id;

        /// <summary>
        /// The total time the hand has been present in seconds.
        /// </summary>
        private int Age { get; } = age;

        /// <summary>
        /// The collection of touch points related to this hand.
        /// </summary>
        private List<Touch> Fingers { get; } = fingers;
    }
}
