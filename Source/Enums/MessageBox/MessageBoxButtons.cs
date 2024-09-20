using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading;
using System.Threading.Tasks;

namespace WinCS
{
    public static partial class MessageBoxFlags
    {
        public const long MB_ABORTRETRYIGNORE = 0x00000002L;
        public const long MB_CANCELTRYCONTINUE = 0x00000006L;
        public const long MB_HELP = 0x00004000L;
        public const long MB_OK = 0x00000000L;
        public const long MB_OKCANCEL = 0x00000001L;
        public const long MB_RETRYCANCEL = 0x00000005L;
        public const long MB_YESNO = 0x00000004L;
        public const long MB_YESNOCANCEL = 0x00000003L;
    }
}
