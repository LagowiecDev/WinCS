#nullable enable
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyFramework.Windows
{
    [DebuggerDisplay("{Handle}")]
    public readonly struct HBRUSH : IEquatable<HBRUSH>, IComparable<HBRUSH>
    {
        public readonly IntPtr Handle;

        // Constructor to initialize HBRUSH struct
        public HBRUSH(IntPtr handle)
        {
            Handle = handle;
        }

        // Implicit conversion from IntPtr to HBRUSH
        public static implicit operator HBRUSH(IntPtr handle) => new HBRUSH(handle);

        // Implicit conversion from HBRUSH to IntPtr
        public static implicit operator IntPtr(HBRUSH hbrush) => hbrush.Handle;

        // Equality comparison
        public bool Equals(HBRUSH other) => Handle == other.Handle;
        public override bool Equals(object? obj) => obj is HBRUSH other && Equals(other);

        public override int GetHashCode() => Handle.GetHashCode();

        // IComparable implementation
        public int CompareTo(HBRUSH other) => Handle.ToInt64().CompareTo(other.Handle.ToInt64());

        public override string ToString() => Handle.ToString();

        public static bool operator ==(HBRUSH left, HBRUSH right) => left.Equals(right);
        public static bool operator !=(HBRUSH left, HBRUSH right) => !left.Equals(right);
        public static bool operator <(HBRUSH left, HBRUSH right) => left.CompareTo(right) < 0;
        public static bool operator >(HBRUSH left, HBRUSH right) => left.CompareTo(right) > 0;
    }
}