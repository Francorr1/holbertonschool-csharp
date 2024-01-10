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

        /// <summary>
        /// Private string field that defaults to "(No name)"
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// Public getter/setter
        /// </summary>
        public string Name
        {
            get=> name;
            set=> name = value;
        }

        /// <summary>
        /// Overrides .ToString() to print the Zombie's attributes
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Zombie Name: " + name + " / Total Health: " + health;
        }
    }
}