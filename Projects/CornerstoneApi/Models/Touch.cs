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

        public Touch(int id, int age, float distance, Vector2 position) 
        {
            if (id < 0) {
                throw new ArgumentException("Id cannot be negative");
            }

            if (age < 0) {
                throw new ArgumentException("Age cannot be negative");
            }

            if (distance < 0.0f || distance > 1.0f) {
                throw new ArgumentException("Distance should be between 0 and 1");
            }

            if (position.X < 0.0f || position.Y < 0.0f) {
                throw new ArgumentException("Position cannot have values lower than 0");
            }

            Id = id;
            Age = age;
            Distance = distance;
            Position = position;
        }
    }
}