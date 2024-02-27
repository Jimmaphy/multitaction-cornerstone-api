using System.Numerics;

namespace MultitactionCornerstoneApi.Models
{
    /// <summary>
    /// Contains information about a single touch point on the screen.
    /// A touch points represents a finger on the screen.
    /// </summary>
    public class Touch
    {
        /// <summary>
        /// The unique identifier for this point.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// The total time the point has been present in seconds.
        /// </summary>
        public int Age { get; private set; } 

        /// <summary>
        /// The distance of the finger from the screen.
        /// </summary>
        public float Distance { get; private set; } 

        /// <summary>
        /// The position of the point on the screen.
        /// </summary>
        public Vector2 Position { get; private set; }

        /// <summary>
        /// Create an instance of the Touch class, providing id, age, distance and position.
        /// The id, age, distance and position should be positive.
        /// The distance should be smaller than 1.0.
        /// </summary>
        /// <param name="id">The unique identifier for this point</param>
        /// <param name="age">The total time the point has been present in seconds</param>
        /// <param name="distance">The distance of the finger from the screen</param>
        /// <param name="position">The position of the point on the screen</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Touch(int id, int age, float distance, Vector2 position) 
        {
            ArgumentOutOfRangeException.ThrowIfNegative(id);
            ArgumentOutOfRangeException.ThrowIfNegative(age);
            ArgumentOutOfRangeException.ThrowIfNegative(distance);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(distance, 1.0f);
            ArgumentOutOfRangeException.ThrowIfNegative(position.X);
            ArgumentOutOfRangeException.ThrowIfNegative(position.Y);

            Id = id;
            Age = age;
            Distance = distance;
            Position = position;
        }
    }
}