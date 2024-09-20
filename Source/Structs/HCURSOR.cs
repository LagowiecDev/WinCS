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
    public readonly struct HCURSOR : IEquatable<HCURSOR>, IComparable<HCURSOR>
    {
        public readonly IntPtr Handle;

        public HCURSOR(IntPtr handle)
        {
            Handle = handle;
        }

        public static implicit operator HCURSOR(IntPtr handle) => new HCURSOR(handle);
        public static implicit operator IntPtr(HCURSOR hcursor) => hcursor.Handle;

        public bool Equals(HCURSOR other) => Handle == other.Handle;
        public override bool Equals(object? obj) => obj is HCURSOR other && Equals(other);

        public override int GetHashCode() => Handle.GetHashCode();
        public int CompareTo(HCURSOR other) => Handle.ToInt64().CompareTo(other.Handle.ToInt64());

        public override string ToString() => Handle.ToString();

        public static bool operator ==(HCURSOR left, HCURSOR right) => left.Equals(right);
        public static bool operator !=(HCURSOR left, HCURSOR right) => !left.Equals(right);
        public static bool operator <(HCURSOR left, HCURSOR right) => left.CompareTo(right) < 0;
        public static bool operator >(HCURSOR left, HCURSOR right) => left.CompareTo(right) > 0;
    }
}
