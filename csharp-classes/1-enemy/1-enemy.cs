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
    }
}