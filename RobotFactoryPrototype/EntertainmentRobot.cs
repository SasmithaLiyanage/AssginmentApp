using System;

namespace RobotFactoryPrototype
{
    /// <summary>
    /// A robot used for entertainment (theme parks, events etc.).
    /// </summary>
    public class EntertainmentRobot : Robot
    {
        /// <summary>
        /// The special entertainment feature this robot offers.
        /// </summary>
        public string EntertainmentFeature { get; set; } = string.Empty;

        /// <summary>
        /// Clone returns the concrete type.
        /// </summary>
        public override Robot Clone()
        {
            return (EntertainmentRobot)MemberwiseClone();
        }

        /// <summary>
        /// Displays all robot details including the unique property.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("EntertainmentRobot:");
            Console.WriteLine($"  ModelName: {ModelName}");
            Console.WriteLine($"  BatteryCapacity: {BatteryCapacity} hours");
            Console.WriteLine($"  SoftwareVersion: {SoftwareVersion}");
            Console.WriteLine($"  EntertainmentFeature: {EntertainmentFeature}");
        }
    }
}
