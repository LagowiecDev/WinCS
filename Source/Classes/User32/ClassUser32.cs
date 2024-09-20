using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SpicyFramework.Windows
{
    public static partial class User32
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern ATOM RegisterClassW(
            [In] WNDCLASSW lpWndClass
        );

        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern ATOM RegisterClassA(
            [In] WNDCLASSA lpWndClass
        );

        public static ATOM RegisterClass(
            [In] WNDCLASS lpWndClass,
            bool usesWideCharacters = true
        )
        {
            if (usesWideCharacters)
                return RegisterClassW(lpWndClass);

            return RegisterClassA(lpWndClass);
        }

        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool UnregisterClassA(
          [In] LPCSTR lpClassName,
          [In, Optional] HINSTANCE hInstance
        );

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool UnregisterClassW(
          [In] LPCWSTR lpClassName,
          [In, Optional] HINSTANCE hInstance
        );

        public static bool UnregisterClass(
          [In] string lpClassName,
          [In, Optional] HINSTANCE hInstance,
          bool usesWideCharacters = true
        )
        {
            if (usesWideCharacters)
                return UnregisterClassW(lpClassName, hInstance);

            return UnregisterClassA(lpClassName, hInstance);
        }
    }
}
