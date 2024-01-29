using System;

namespace Enemies
{
    /// <summary>
    /// Class defining a Zombie and setting its health to 0
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Public int field that stores the health of the enemy
        /// </summary>
        public int health;
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
    }
}