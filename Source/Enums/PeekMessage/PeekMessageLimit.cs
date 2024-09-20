using System;

namespace WinCS
{
    public static partial class PeekMessageFlags
    {
        public const int PM_QS_INPUT = (0x0001 << 16);        // Process mouse and keyboard messages
        public const int PM_QS_PAINT = (0x0002 << 16);       // Process paint messages
        public const int PM_QS_POSTMESSAGE = ((0x0008 | 0x0010 | 0x0020) << 16); // Process all posted messages, including timers and hotkeys
        public const int PM_QS_SENDMESSAGE = (0x0040 << 16); // Process send messages
    }
}