#nullable enable
using System;
using System.Diagnostics;

namespace WinCS
{
    [DebuggerDisplay("{Value}")]
    public readonly struct ATOM : IEquatable<ATOM>
    {
        private readonly ushort value;

        public ATOM(ushort value)
        {
            this.value = value;
        }

        public readonly ushort Value => value;

        public static ATOM Null => default;

        public bool IsNull => Value == default;

        public static implicit operator ushort(ATOM value) => value.Value;

        public static implicit operator ATOM(ushort value) => new ATOM(value);

        public static bool operator ==(ATOM left, ATOM right) => left.Value == right.Value;

        public static bool operator !=(ATOM left, ATOM right) => !(left == right);

        public bool Equals(ATOM other) => Value == other.Value;

        public override bool Equals(object? obj) => obj is ATOM other && Equals(other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();
    }
}