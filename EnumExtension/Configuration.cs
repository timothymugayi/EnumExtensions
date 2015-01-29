using System;

namespace EnumExtension
{
    /// <summary>
    ///     Custom Attribute that defines additional attributes for each enum constant
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class Configuration : Attribute
    {
        private readonly string _description;
        private readonly ErrorPriority _priority;
        private readonly ErrorSource _source;

        /// <summary>
        ///     Configuration constructor for enum
        /// </summary>
        /// <param name="description">Error description</param>
        /// <param name="priority">Error priority</param>
        /// <param name="source">Error source</param>
        public Configuration(string description, ErrorPriority priority, ErrorSource source)
        {
            _description = description;
            _priority = priority;
            _source = source;
        }

        public string Description
        {
            get { return _description; }
        }

        public ErrorPriority Priority
        {
            get { return _priority; }
        }

        public ErrorSource Source
        {
            get { return _source; }
        }
    }
}