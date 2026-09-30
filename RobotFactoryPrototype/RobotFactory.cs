namespace RobotFactoryPrototype
{
    /// <summary>
    /// Factory that orders robots by cloning registered prototypes and applying small customizations.
    /// </summary>
    public class RobotFactory
    {
        private readonly RobotRegistry _registry;

        public RobotFactory(RobotRegistry registry)
        {
            _registry = registry;
        }

        /// <summary>
        /// Orders a robot of the given type, customizing battery capacity and software version if provided.
        /// The robot is produced by cloning a registered prototype rather than constructing from scratch.
        /// </summary>
        public Robot? OrderRobot(string type, double? batteryCapacity, string? softwareVersion)
        {
            var robot = _registry.GetClone(type);
            if (robot == null) return null;

            if (batteryCapacity.HasValue)
            {
                robot.BatteryCapacity = batteryCapacity.Value;
            }

            if (!string.IsNullOrEmpty(softwareVersion))
            {
                robot.SoftwareVersion = softwareVersion;
            }

            return robot;
        }
    }
}
