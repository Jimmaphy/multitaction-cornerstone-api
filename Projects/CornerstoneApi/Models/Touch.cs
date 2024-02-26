using System.Numerics;

namespace MultitactionCornerstoneApi.Models
{
    /// <summary>
    /// Contains information about a single touch point on the screen.
    /// A touch points represents a finger on the screen.
    /// </summary>
    /// <param name="id">The unique identifier for this point</param>
    /// <param name="age">The total time the point has been present in seconds</param>
    /// <param name="distance">The distance of the finger from the screen</param>
    /// <param name="position">The position of the point on the screen</param>
    public class Touch(int id, int age, float distance, Vector2 position)
    {
        /// <summary>
        /// The unique identifier for this point.
        /// </summary>
        private int Id { get;  } = id;

        /// <summary>
        /// The total time the point has been present in seconds.
        /// </summary>
        private int Age { get; } = age;

        /// <summary>
        /// The distance of the finger from the screen.
        /// </summary>
        private float Distance { get; } = distance;

        /// <summary>
        /// The position of the point on the screen.
        /// </summary>
        private Vector2 Position { get; } = position;
    }
}