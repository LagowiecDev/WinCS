using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyFramework.Windows
{
    public static partial class MessageBoxFlags
    {
        public const long MB_ICONEXCLAMATION = 0x00000030L;
        public const long MB_ICONWARNING = 0x00000030L;
        public const long MB_ICONINFORMATION = 0x00000040L;
        public const long MB_ICONASTERISK = 0x00000040L;
        public const long MB_ICONQUESTION = 0x00000020L;
        public const long MB_ICONSTOP = 0x00000010L;
        public const long MB_ICONERROR = 0x00000010L;
        public const long MB_ICONHAND = 0x00000010L;
    }
}