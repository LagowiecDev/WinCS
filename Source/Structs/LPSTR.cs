using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCS
{
    public readonly struct LPSTR
    {
        public readonly string Value;

        public LPSTR(string value)
        {
            Value = value;
        }

        public static implicit operator LPSTR(string value) => new LPSTR(value);
        public static implicit operator string(LPSTR lpStr) => lpStr.Value;

        public override string ToString() => Value;
    }
}
