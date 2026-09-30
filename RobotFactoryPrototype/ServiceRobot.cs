using System;

namespace RobotFactoryPrototype
{
    /// <summary>
    /// A robot for service scenarios (hospitality, healthcare etc.).
    /// </summary>
    public class ServiceRobot : Robot
    {
        /// <summary>
        /// The primary service task this robot performs.
        /// </summary>
        public string ServiceTask { get; set; } = string.Empty;

        /// <summary>
        /// Clone returns the concrete type.
        /// </summary>
        public override Robot Clone()
        {
            return (ServiceRobot)MemberwiseClone();
        }

        /// <summary>
        /// Displays all robot details including the unique property.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("ServiceRobot:");
            Console.WriteLine($"  ModelName: {ModelName}");
            Console.WriteLine($"  BatteryCapacity: {BatteryCapacity} hours");
            Console.WriteLine($"  SoftwareVersion: {SoftwareVersion}");
            Console.WriteLine($"  ServiceTask: {ServiceTask}");
        }
    }
}
