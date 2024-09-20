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
    public readonly struct HMENU : IEquatable<HMENU>
    {
        public readonly IntPtr Value;

        public HMENU(IntPtr value) => Value = value;

        public static HMENU Null => default;

        public bool IsNull => Value == default;

        public static implicit operator IntPtr(HMENU value) => value.Value;

        public static implicit operator HMENU(IntPtr value) => new HMENU(value);

        public static bool operator ==(HMENU left, HMENU right) => left.Value == right.Value;

        public static bool operator !=(HMENU left, HMENU right) => !(left == right);

        public bool Equals(HMENU other) => Value == other.Value;

        public override bool Equals(object? obj) => obj is HMENU other && Equals(other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"0x{Value:x}";
    }
}
