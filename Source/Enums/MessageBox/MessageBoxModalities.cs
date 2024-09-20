using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCS
{
    public static partial class MessageBoxFlags
    {
        public const long MB_APPLMODAL = 0x00000000L;
        public const long MB_SYSTEMMODAL = 0x00001000L;
        public const long MB_TASKMODAL = 0x00002000L;
    }
}