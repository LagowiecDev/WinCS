using WinCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinCS
{
    public static partial class User32
    {
        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int MessageBoxA(
          [In, Optional] HWND hWnd,
          [In, Optional] LPCSTR lpText,
          [In, Optional] LPCSTR lpCaption,
          [In] long uType
        );

        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int MessageBoxW(
          [In, Optional] HWND hWnd,
          [In, Optional] LPCWSTR lpText,
          [In, Optional] LPCWSTR lpCaption,
          [In] long uType
        );

        public static int MessageBox(
          [In, Optional] HWND hWnd,
          [In, Optional] string lpText,
          [In, Optional] string lpCaption,
          [In] long uType,
          bool usesWideCharacters = true
        )
        {
            if (usesWideCharacters)
                return MessageBoxW(hWnd, lpText, lpCaption, uType);

            return MessageBoxA(hWnd, lpText, lpCaption, uType);
        }
    }
}
