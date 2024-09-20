#nullable enable
using System;
using System.Diagnostics;

namespace SpicyFramework.Windows
{
    [DebuggerDisplay("{Value}")]
    public readonly struct DWORD : IEquatable<DWORD>, IComparable<DWORD>
    {
        public readonly uint Value;

        // Constructor to initialize the DWORD struct
        public DWORD(uint value)
        {
            Value = value;
        }

        // Implicit conversion from uint to DWORD
        public static implicit operator DWORD(uint value) => new DWORD(value);

        // Implicit conversion from DWORD to uint
        public static implicit operator uint(DWORD dword) => dword.Value;

        // Equality comparison
        public bool Equals(DWORD other) => Value == other.Value;
        public override bool Equals(object? obj) => obj is DWORD other && Equals(other);

        // Override GetHashCode for proper use in hash-based collections
        public override int GetHashCode() => Value.GetHashCode();

        // IComparable implementation
        public int CompareTo(DWORD other) => Value.CompareTo(other.Value);

        // Override ToString to display the value
        public override string ToString() => Value.ToString();

        // Operators for easier comparison
        public static bool operator ==(DWORD left, DWORD right) => left.Equals(right);
        public static bool operator !=(DWORD left, DWORD right) => !left.Equals(right);
        public static bool operator <(DWORD left, DWORD right) => left.CompareTo(right) < 0;
        public static bool operator >(DWORD left, DWORD right) => left.CompareTo(right) > 0;
        public static bool operator <=(DWORD left, DWORD right) => left.CompareTo(right) <= 0;
        public static bool operator >=(DWORD left, DWORD right) => left.CompareTo(right) >= 0;
    }
}