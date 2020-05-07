using System;

namespace Buzzing.Bees
{
    internal class Bee
    {
        public int Health { get; internal set; }

        internal Bee()
        {
            Health = 100;
        }

        /// <summary>
        /// Reduces health by a specified percentage.
        /// </summary>
        /// <param name="percentage">A whole number repersenting a %.</param>
        public void Damage(int percentage)
        {
            if (percentage > 100)
                throw new ArgumentException("Percentage reduction cannot be greater than 100");

            Health = RemovePercentageOfHealth(percentage, Health);
        }

        private static int RemovePercentageOfHealth(int percentage, int health)
        {
            // Reduces health by turining the percentage reduction given into a multiplier
            // so we can work out the number post reduction.
            float percentageMultiplier = 1.0f - (float)percentage / 100.0f;

            return (int)((float)health * percentageMultiplier);
        }
    }
}
