using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyFramework.Windows
{
    public readonly struct LPCVOID
    {
        public readonly IntPtr Value;

        public LPCVOID(IntPtr value)
        {
            Value = value;
        }

        public static implicit operator LPCVOID(IntPtr value) => new LPCVOID(value);
        public static implicit operator IntPtr(LPCVOID lpVoid) => lpVoid.Value;

        public override string ToString() => Value.ToString();
    }
}
