using System;

namespace WinCS
{
    public static partial class PeekMessageFlags
    {
        public const int PM_NOREMOVE = 0x0000; // Messages are not removed from the queue after processing
        public const int PM_REMOVE = 0x0001;    // Messages are removed from the queue after processing
        public const int PM_NOYIELD = 0x0002;   // Prevents the thread from yielding to other threads
    }
}