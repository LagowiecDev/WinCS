#nullable enable
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SpicyFramework.Windows
{
    [DebuggerDisplay("{Value}")]
    public readonly struct LPCSTR : IEquatable<LPCSTR>
    {
        public readonly IntPtr Value;

        public LPCSTR(string value)
        {
            Value = Marshal.StringToHGlobalAnsi(value);
        }

        public static LPCSTR Null => default;

        public bool IsNull => Value == IntPtr.Zero;

        public static implicit operator IntPtr(LPCSTR value) => value.Value;

        public static implicit operator LPCSTR(string value) => new LPCSTR(value);

        public static bool operator ==(LPCSTR left, LPCSTR right) => left.Value == right.Value;

        public static bool operator !=(LPCSTR left, LPCSTR right) => !(left == right);

        public bool Equals(LPCSTR other) => Value == other.Value;

        public override bool Equals(object? obj) => obj is LPCSTR other && Equals(other);

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