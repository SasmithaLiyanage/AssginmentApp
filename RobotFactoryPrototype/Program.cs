using System;

namespace RobotFactoryPrototype
{
    internal static class Program
    {
        /// <summary>
        /// Demonstrates the Prototype pattern with robot prototypes, cloning, and customization.
        /// </summary>
        private static void Main()
        {
            var registry = new RobotRegistry();

            // Register prototypes
            var servicePrototype = new ServiceRobot
            {
                ModelName = "S-100",
                BatteryCapacity = 8.0,
                SoftwareVersion = "1.0.0",
                ServiceTask = "Room Service"
            };

            var industrialPrototype = new IndustrialRobot
            {
                ModelName = "I-9000",
                BatteryCapacity = 24.0,
                SoftwareVersion = "3.2.1",
                IndustrialTask = "Spot Welding"
            };

            var entertainmentPrototype = new EntertainmentRobot
            {
                ModelName = "E-Glow",
                BatteryCapacity = 6.5,
                SoftwareVersion = "2.0.5",
                EntertainmentFeature = "LED Dance"
            };

            registry.RegisterPrototype("service", servicePrototype);
            registry.RegisterPrototype("industrial", industrialPrototype);
            registry.RegisterPrototype("entertainment", entertainmentPrototype);

            var factory = new RobotFactory(registry);

            // Order multiple customized robots from prototypes
            var serviceClone1 = factory.OrderRobot("service", 10.0, "1.1.0") as ServiceRobot;
            var serviceClone2 = factory.OrderRobot("service", 12.5, "1.2.0") as ServiceRobot;

            var industrialClone = factory.OrderRobot("industrial", 30.0, "3.3.0") as IndustrialRobot;
            var entertainmentClone = factory.OrderRobot("entertainment", 7.0, "2.1.0") as EntertainmentRobot;

            Console.WriteLine("--- Clones ---");
            serviceClone1?.Display();
            Console.WriteLine();
            serviceClone2?.Display();
            Console.WriteLine();
            industrialClone?.Display();
            Console.WriteLine();
            entertainmentClone?.Display();
            Console.WriteLine();

            // Show original prototypes remain unchanged
            Console.WriteLine("--- Original Prototypes (unchanged) ---");
            registry.GetPrototype("service")?.Display();
            Console.WriteLine();
            registry.GetPrototype("industrial")?.Display();
            Console.WriteLine();
            registry.GetPrototype("entertainment")?.Display();
            Console.WriteLine();

            // Show clones are different object instances
            Console.WriteLine("Reference equality checks:");
            Console.WriteLine($"serviceClone1 vs prototype: {ReferenceEquals(serviceClone1, servicePrototype)}");
            Console.WriteLine($"serviceClone1 vs serviceClone2: {ReferenceEquals(serviceClone1, serviceClone2)}");

            Console.WriteLine();
            Console.WriteLine("Why Prototype improves efficiency:");
            Console.WriteLine("- Creating a clone is typically cheaper than building from scratch when prototypes contain complex setup or default state.");
            Console.WriteLine("- Customization after cloning avoids repeated initialization logic and preserves a known-good base configuration.");
            Console.WriteLine("- This reduces object construction cost, memory churn, and can improve startup/throughput in factories producing many similar objects.");
        }
    }
}
