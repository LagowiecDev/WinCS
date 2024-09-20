using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SpicyFramework.Windows
{
    public static partial class Kernel32
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern DWORD FormatMessageA(
          [In] DWORD dwFlags,
          [In, Optional] LPCVOID lpSource,
          [In] DWORD dwMessageId,
          [In] DWORD dwLanguageId,
          [Out] LPSTR lpBuffer,
          [In] DWORD nSize,
          [In, Optional] string[] Arguments
        );
    }
}
