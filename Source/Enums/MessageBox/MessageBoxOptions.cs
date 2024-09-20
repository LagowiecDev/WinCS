using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyFramework.Windows
{
    public static partial class MessageBoxFlags
    {
        public const long MB_DEFAULT_DESKTOP_ONLY = 0x00020000L;
        public const long MB_RIGHT = 0x00080000L;
        public const long MB_RTLREADING = 0x00100000L;
        public const long MB_SETFOREGROUND = 0x00010000L;
        public const long MB_TOPMOST = 0x00040000L;
        public const long MB_SERVICE_NOTIFICATION = 0x00200000L;
    }
}