using System;

namespace Enemies
{
    /// <summary>
    /// Class defining a Zombie and setting its health to 0
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Private int field that stores the health of the enemy
        /// </summary>
        private int health;
        /// <summary>
        /// Public constructor that sets the health to 0
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>
        /// Updates the health value
        /// </summary>
        /// <param name="value"></param>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
        /// <summary>
        /// Returns the current value of health
        /// </summary>
        /// <returns></returns>
        public int GetHealth()
        {
            return health;
        }
    }
}