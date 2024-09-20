using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCS
{
    public static partial class WindowsMessagesFlags
    {
        public const uint WM_NULL = 0x0000;
        public const uint WM_CREATE = 0x0001;
        public const uint WM_DESTROY = 0x0002;
        public const uint WM_MOVE = 0x0003;
        public const uint WM_SIZE = 0x0005;
        public const uint WM_SHOWWINDOW = 0x0018;
        public const uint WM_CLOSE = 0x0010;
        public const uint WM_QUIT = 0x0012;
        public const uint WM_PAINT = 0x000F;
        public const uint WM_KEYDOWN = 0x0100;
        public const uint WM_KEYUP = 0x0101;
        public const uint WM_MOUSEMOVE = 0x0200;
        public const uint WM_LBUTTONDOWN = 0x0201;
        public const uint WM_LBUTTONUP = 0x0202;
    }
}
