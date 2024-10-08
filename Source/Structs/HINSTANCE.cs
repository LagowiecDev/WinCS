﻿#nullable enable
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WinCS
{
    [DebuggerDisplay("{Value}")]
    public readonly struct HINSTANCE : IEquatable<HINSTANCE>
    {
        public readonly IntPtr Value;

        public HINSTANCE(IntPtr value) => Value = value;

        public static HINSTANCE Null => default;

        public bool IsNull => Value == default;

        public static implicit operator IntPtr(HINSTANCE value) => value.Value;

        public static implicit operator HINSTANCE(IntPtr value) => new HINSTANCE(value);

        public static bool operator ==(HINSTANCE left, HINSTANCE right) => left.Value == right.Value;

        public static bool operator !=(HINSTANCE left, HINSTANCE right) => !(left == right);

        public bool Equals(HINSTANCE other) => Value == other.Value;

        public override bool Equals(object? obj) => obj is HINSTANCE other && Equals(other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"0x{Value:x}";

        public static implicit operator HMODULE(HINSTANCE value) => new HMODULE(value.Value);
    }
}