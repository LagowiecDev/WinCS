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
        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern LRESULT DefWindowProcA(
            HWND hWnd,
            uint Msg,
            WPARAM wParam,
            LPARAM lParam
        );

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern LRESULT DefWindowProcW(
            HWND hWnd,
            uint Msg,
            WPARAM wParam,
            LPARAM lParam
        );

        public static LRESULT DefWindowProc(
            HWND hWnd,
            uint Msg,
            WPARAM wParam,
            LPARAM lParam,
            bool usesWideCharacters = true
        )
        {
            if (usesWideCharacters)
                return DefWindowProcW(hWnd, Msg, wParam, lParam);

            return DefWindowProcA(hWnd, Msg, wParam, lParam);
        }
    }
}
