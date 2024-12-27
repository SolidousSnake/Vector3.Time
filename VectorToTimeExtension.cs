using UnityEngine;

namespace _Project.Code.Utils
{
    public static class VectorToTimeExtension
    {
        /// <summary>
        /// Calculates the time required to travel the distance represented by the Vector3 with a given speed.
        /// </summary>
        /// <param name="distance">The distance as a Vector3.</param>
        /// <param name="speed">The speed of travel (must be greater than zero).</param>
        /// <returns>The time required to travel the distance. Returns float.PositiveInfinity if speed is zero.</returns>
        public static float Time(this Vector3 distance, float speed)
        {
            if (speed <= 0f)
            {
                Debug.LogWarning("Bro, how did you get a negative speed?");
                return float.PositiveInfinity;
            }

            float distanceMagnitude = distance.magnitude;
            return distanceMagnitude / speed;
        }
    }
}