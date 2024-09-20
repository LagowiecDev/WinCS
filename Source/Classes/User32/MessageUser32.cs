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
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool TranslateMessage(
          [In] MSG lpMsg
        );

        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern LRESULT DispatchMessageA(
          [In] MSG lpMsg
        );

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern LRESULT DispatchMessageW(
          [In] MSG lpMsg
        );

        public static LRESULT DispatchMessage(
            [In] MSG lpMsg,
            bool usesWideCharacters = true
        )
        {
            if (usesWideCharacters)
                return DispatchMessageW(lpMsg);

            return DispatchMessageA(lpMsg);
        }

        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GetMessageA(
          ref MSG lpMsg,
          [In, Optional] HWND hWnd,
          [In] uint wMsgFilterMin,
          [In] uint wMsgFilterMax
        );

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool GetMessageW(
          ref MSG lpMsg,
          [In, Optional] HWND hWnd,
          [In] uint wMsgFilterMin,
          [In] uint wMsgFilterMax
        );

        public static bool GetMessage(
          ref MSG lpMsg,
          [In, Optional] HWND hWnd,
          [In] uint wMsgFilterMin,
          [In] uint wMsgFilterMax,
          bool usesWideCharacters = true
        )
        {
            if (usesWideCharacters)
                return GetMessageW(ref lpMsg, hWnd, wMsgFilterMin, wMsgFilterMax);

            return GetMessageA(ref lpMsg, hWnd, wMsgFilterMin, wMsgFilterMax);
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern void PostQuitMessage(
          [In] int nExitCode
        );

        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool PeekMessageA(
          ref MSG lpMsg,
          [In, Optional] HWND hWnd,
          [In] uint wMsgFilterMin,
          [In] uint wMsgFilterMax,
          [In] uint wRemoveMsg
        );

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool PeekMessageW(
          ref MSG lpMsg,
          [In, Optional] HWND hWnd,
          [In] uint wMsgFilterMin,
          [In] uint wMsgFilterMax,
          [In] uint wRemoveMsg
        );

        public static bool PeekMessage(
          ref MSG lpMsg,
          [In, Optional] HWND hWnd,
          [In] uint wMsgFilterMin,
          [In] uint wMsgFilterMax,
          [In] uint wRemoveMsg,
          bool usesWideCharacters = true
        )
        {
            if (usesWideCharacters)
                return PeekMessageW(ref lpMsg, hWnd, wMsgFilterMin, wMsgFilterMax, wRemoveMsg);

            return PeekMessageA(ref lpMsg, hWnd, wMsgFilterMin, wMsgFilterMax, wRemoveMsg);
        }
    }
}