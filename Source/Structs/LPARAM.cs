#nullable enable
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyFramework.Windows
{
    [DebuggerDisplay("{Value}")]
    public readonly struct LPARAM : IEquatable<LPARAM>, IComparable<LPARAM>
    {
        public readonly IntPtr Value;

        // Constructor to initialize LPARAM struct
        public LPARAM(IntPtr value)
        {
            Value = value;
        }

        // Implicit conversion from IntPtr to LPARAM
        public static implicit operator LPARAM(IntPtr value) => new LPARAM(value);

        // Implicit conversion from LPARAM to IntPtr
        public static implicit operator IntPtr(LPARAM lparam) => lparam.Value;

        // Equality comparison
        public bool Equals(LPARAM other) => Value == other.Value;
        public override bool Equals(object? obj) => obj is LPARAM other && Equals(other);

        public override int GetHashCode() => Value.GetHashCode();

        // IComparable implementation
        public int CompareTo(LPARAM other) => Value.ToInt64().CompareTo(other.Value.ToInt64());

        public override string ToString() => Value.ToString();

        public static bool operator ==(LPARAM left, LPARAM right) => left.Equals(right);
        public static bool operator !=(LPARAM left, LPARAM right) => !left.Equals(right);
        public static bool operator <(LPARAM left, LPARAM right) => left.CompareTo(right) < 0;
        public static bool operator >(LPARAM left, LPARAM right) => left.CompareTo(right) > 0;
        public static bool operator <=(LPARAM left, LPARAM right) => left.CompareTo(right) <= 0;
        public static bool operator >=(LPARAM left, LPARAM right) => left.CompareTo(right) >= 0;
    }
}
