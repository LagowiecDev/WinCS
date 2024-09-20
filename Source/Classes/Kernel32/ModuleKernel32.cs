
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinCS
{
    public static partial class Kernel32
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern HMODULE GetModuleHandleA(
          [In, Optional] LPCSTR lpModuleName
        );

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HMODULE GetModuleHandleW(
          [In, Optional] LPCWSTR lpModuleName
        );

        public static HMODULE GetModuleHandle(
          [In, Optional] string lpModuleName,
          bool usesWideCharacters = true
        )
        {
            if (usesWideCharacters)
                return GetModuleHandleW(lpModuleName);

            return GetModuleHandleA(lpModuleName);
        }
    }
}
