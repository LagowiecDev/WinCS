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
    public readonly struct LPVOID : IEquatable<LPVOID>
    {
        public readonly IntPtr Value;

        public LPVOID(IntPtr value) => Value = value;

        public static LPVOID Null => default;

        public bool IsNull => Value == default;

        public static implicit operator IntPtr(LPVOID value) => value.Value;

        public static implicit operator LPVOID(IntPtr value) => new LPVOID(value);

        public static bool operator ==(LPVOID left, LPVOID right) => left.Value == right.Value;

        public static bool operator !=(LPVOID left, LPVOID right) => !(left == right);

        public bool Equals(LPVOID other) => Value == other.Value;

        public override bool Equals(object? obj) => obj is LPVOID other && Equals(other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"0x{Value:x}";
    }
}