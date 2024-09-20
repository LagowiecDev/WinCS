#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyFramework.Windows
{
    public readonly struct LRESULT
    {
        public readonly IntPtr Value;

        public LRESULT(IntPtr value)
        {
            Value = value;
        }

        public static implicit operator LRESULT(IntPtr value) => new LRESULT(value);
        public static implicit operator IntPtr(LRESULT lResult) => lResult.Value;

        public override string ToString() => Value.ToString();
    }
}
