using System;

namespace RobotFactoryPrototype
{
    /// <summary>
    /// A robot used in industrial scenarios (welding, assembly etc.).
    /// </summary>
    public class IndustrialRobot : Robot
    {
        /// <summary>
        /// The industrial task this robot performs.
        /// </summary>
        public string IndustrialTask { get; set; } = string.Empty;

        /// <summary>
        /// Clone returns the concrete type.
        /// </summary>
        public override Robot Clone()
        {
            return (IndustrialRobot)MemberwiseClone();
        }

        /// <summary>
        /// Displays all robot details including the unique property.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("IndustrialRobot:");
            Console.WriteLine($"  ModelName: {ModelName}");
            Console.WriteLine($"  BatteryCapacity: {BatteryCapacity} hours");
            Console.WriteLine($"  SoftwareVersion: {SoftwareVersion}");
            Console.WriteLine($"  IndustrialTask: {IndustrialTask}");
        }
    }
}
