using System.Collections.Generic;

namespace RobotFactoryPrototype
{
    /// <summary>
    /// Stores robot prototypes and returns clones on demand.
    /// </summary>
    public class RobotRegistry
    {
        private readonly Dictionary<string, Robot> _prototypes = new();

        /// <summary>
        /// Registers or replaces a prototype under the given key.
        /// </summary>
        public void RegisterPrototype(string key, Robot robot) => _prototypes[key] = robot;

        /// <summary>
        /// Returns a cloned robot for the given key, or null if not found.
        /// </summary>
        public Robot? GetClone(string key)
        {
            if (_prototypes.TryGetValue(key, out var prototype))
            {
                return prototype.Clone();
            }
            return null;
        }

        /// <summary>
        /// Returns the registered prototype instance (for demonstration only).
        /// </summary>
        public Robot? GetPrototype(string key) => _prototypes.TryGetValue(key, out var p) ? p : null;
    }
}
