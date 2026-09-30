namespace RobotFactoryPrototype
{
    /// <summary>
    /// Prototype interface for robots.
    /// </summary>
    public interface IRobotPrototype
    {
        /// <summary>
        /// Creates a clone of the robot.
        /// </summary>
        Robot Clone();
    }
}
