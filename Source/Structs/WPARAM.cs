#nullable enable
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCS
{
    [DebuggerDisplay("{Value}")]
    public readonly struct WPARAM : IEquatable<WPARAM>, IComparable<WPARAM>
    {
        public readonly UIntPtr Value;

        // Constructor to initialize WPARAM struct
        public WPARAM(UIntPtr value)
        {
            Value = value;
        }

        // Implicit conversion from UIntPtr to WPARAM
        public static implicit operator WPARAM(UIntPtr value) => new WPARAM(value);

        // Implicit conversion from WPARAM to UIntPtr
        public static implicit operator UIntPtr(WPARAM wparam) => wparam.Value;

        // Equality comparison
        public bool Equals(WPARAM other) => Value == other.Value;
        public override bool Equals(object? obj) => obj is WPARAM other && Equals(other);

        public override int GetHashCode() => Value.GetHashCode();

        // IComparable implementation
        public int CompareTo(WPARAM other) => Value.ToUInt64().CompareTo(other.Value.ToUInt64());

        public override string ToString() => Value.ToString();

        public static bool operator ==(WPARAM left, WPARAM right) => left.Equals(right);
        public static bool operator !=(WPARAM left, WPARAM right) => !left.Equals(right);
        public static bool operator <(WPARAM left, WPARAM right) => left.CompareTo(right) < 0;
        public static bool operator >(WPARAM left, WPARAM right) => left.CompareTo(right) > 0;
        public static bool operator <=(WPARAM left, WPARAM right) => left.CompareTo(right) <= 0;
        public static bool operator >=(WPARAM left, WPARAM right) => left.CompareTo(right) >= 0;
    }
}
