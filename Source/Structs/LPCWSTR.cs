#nullable enable
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SpicyFramework.Windows
{
    [DebuggerDisplay("{Value}")]
    public readonly struct LPCWSTR : IEquatable<LPCWSTR>
    {
        public readonly IntPtr Value;

        public LPCWSTR(string value)
        {
            Value = Marshal.StringToHGlobalUni(value);
        }

        public static LPCWSTR Null => default;

        public bool IsNull => Value == IntPtr.Zero;

        public static implicit operator IntPtr(LPCWSTR value) => value.Value;

        public static implicit operator LPCWSTR(string value) => new LPCWSTR(value);

        public static bool operator ==(LPCWSTR left, LPCWSTR right) => left.Value == right.Value;

        public static bool operator !=(LPCWSTR left, LPCWSTR right) => !(left == right);

        public bool Equals(LPCWSTR other) => Value == other.Value;

        public override bool Equals(object? obj) => obj is LPCWSTR other && Equals(other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"0x{Value:x}";

        public void Free()
        {
            if (Value != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(Value);
            }
        }
    }
}
