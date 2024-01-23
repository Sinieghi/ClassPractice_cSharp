using System;

namespace Practice
{
    class LogRecord
    {

        public string? Name { get; set; }

        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is not LogRecord) return false;
            LogRecord? other = obj as LogRecord;
            return Name.Equals(other?.Name);
        }

    }
}