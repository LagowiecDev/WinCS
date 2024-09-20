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
    public readonly struct HICON : IEquatable<HICON>, IComparable<HICON>
    {
        public readonly IntPtr Handle;

        public HICON(IntPtr handle)
        {
            Handle = handle;
        }

        public static implicit operator HICON(IntPtr handle) => new HICON(handle);
        public static implicit operator IntPtr(HICON hicon) => hicon.Handle;

        public bool Equals(HICON other) => Handle == other.Handle;
        public override bool Equals(object? obj) => obj is HICON other && Equals(other);

        public override int GetHashCode() => Handle.GetHashCode();
        public int CompareTo(HICON other) => Handle.ToInt64().CompareTo(other.Handle.ToInt64());

        public override string ToString() => Handle.ToString();

        public static bool operator ==(HICON left, HICON right) => left.Equals(right);
        public static bool operator !=(HICON left, HICON right) => !left.Equals(right);
        public static bool operator <(HICON left, HICON right) => left.CompareTo(right) < 0;
        public static bool operator >(HICON left, HICON right) => left.CompareTo(right) > 0;
    }
}
