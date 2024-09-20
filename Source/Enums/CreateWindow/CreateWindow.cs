using System;

namespace SpicyFramework.Windows
{
    public static partial class CreateWindowFlags
    {
        public const int CW_USEDEFAULT = unchecked((int)0x80000000);
        public const int CW_NOCOPYBITS = 0x00000001;
        public const int CW_USEDEFAULTSIZE = 0x00000002;

        // Additional flags (these might be less common)
        public const int CW_USEDEFAULTPOSITION = 0x00000004;

        // Note: CW_USEDEFAULT and CW_USEDEFAULTSIZE are often used together
    }
}