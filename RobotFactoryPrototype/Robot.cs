namespace RobotFactoryPrototype
{
    /// <summary>
    /// Base abstract robot implementing the prototype interface.
    /// Contains common properties and a virtual Clone implementation using MemberwiseClone.
    /// </summary>
    public abstract class Robot : IRobotPrototype
    {
        /// <summary>
        /// Model name.
        /// </summary>
        public string ModelName { get; set; } = string.Empty;

        /// <summary>
        /// Battery capacity in hours.
        /// </summary>
        public double BatteryCapacity { get; set; }

        /// <summary>
        /// Software version.
        /// </summary>
        public string SoftwareVersion { get; set; } = string.Empty;

        /// <summary>
        /// Prints robot details to the console.
        /// </summary>
        public abstract void Display();

        /// <summary>
        /// Creates a shallow copy of this robot using MemberwiseClone.
        /// Virtual so derived classes can return their specific type.
        /// </summary>
        public virtual Robot Clone()
        {
            return (Robot)MemberwiseClone();
        }
    }
}
