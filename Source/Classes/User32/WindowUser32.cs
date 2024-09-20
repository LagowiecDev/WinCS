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
        public static HWND CreateWindowA(
          [In, Optional] LPCSTR lpClassName,
          [In, Optional] LPCSTR lpWindowName,
          [In] DWORD dwStyle,
          [In] int X,
          [In] int Y,
          [In] int nWidth,
          [In] int nHeight,
          [In, Optional] HWND hWndParent,
          [In, Optional] HMENU hMenu,
          [In, Optional] HINSTANCE hInstance,
          [In, Optional] LPVOID lpParam
        )
        {
            return CreateWindowExA(0, lpClassName, lpWindowName, dwStyle, X, Y, nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);
        }

        public static HWND CreateWindowW(
            [In, Optional] LPCWSTR lpClassName,
            [In, Optional] LPCWSTR lpWindowName,
            [In] DWORD dwStyle,
            [In] int X,
            [In] int Y,
            [In] int nWidth,
            [In] int nHeight,
            [In, Optional] HWND hWndParent,
            [In, Optional] HMENU hMenu,
            [In, Optional] HINSTANCE hInstance,
            [In, Optional] LPVOID lpParam
        )
        {
            return CreateWindowExW(0, lpClassName, lpWindowName, dwStyle, X, Y, nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);
        }

        public static HWND CreateWindow(
            [In, Optional] string lpClassName,
            [In, Optional] string lpWindowName,
            [In] DWORD dwStyle,
            [In] int X,
            [In] int Y,
            [In] int nWidth,
            [In] int nHeight,
            [In, Optional] HWND hWndParent,
            [In, Optional] HMENU hMenu,
            [In, Optional] HINSTANCE hInstance,
            [In, Optional] LPVOID lpParam,
            bool usesWideCharacters = true
        )
        {
            if (usesWideCharacters)
                return CreateWindowW(lpClassName, lpWindowName, dwStyle, X, Y, nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);

            return CreateWindowA(lpClassName, lpWindowName, dwStyle, X, Y, nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern HWND CreateWindowExA(
          [In] DWORD dwExStyle,
          [In, Optional] LPCSTR lpClassName,
          [In, Optional] LPCSTR lpWindowName,
          [In] uint dwStyle,
          [In] int X,
          [In] int Y,
          [In] int nWidth,
          [In] int nHeight,
          [In, Optional] HWND hWndParent,
          [In, Optional] HMENU hMenu,
          [In, Optional] HINSTANCE hInstance,
          [In, Optional] LPVOID lpParam
        );

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HWND CreateWindowExW(
          [In] DWORD dwExStyle,
          [In, Optional] LPCWSTR lpClassName,
          [In, Optional] LPCWSTR lpWindowName,
          [In] uint dwStyle,
          [In] int X,
          [In] int Y,
          [In] int nWidth,
          [In] int nHeight,
          [In, Optional] HWND hWndParent,
          [In, Optional] HMENU hMenu,
          [In, Optional] HINSTANCE hInstance,
          [In, Optional] LPVOID lpParam
        );

        public static HWND CreateWindowEx(
          [In] DWORD dwExStyle,
          [In, Optional] string lpClassName,
          [In, Optional] string lpWindowName,
          [In] uint dwStyle,
          [In] int X,
          [In] int Y,
          [In] int nWidth,
          [In] int nHeight,
          [In, Optional] HWND hWndParent,
          [In, Optional] HMENU hMenu,
          [In, Optional] HINSTANCE hInstance,
          [In, Optional] LPVOID lpParam,
          bool usesWideCharacters
        )
        {
            if (usesWideCharacters)
                return CreateWindowExW(dwExStyle, lpClassName, lpWindowName, dwStyle, X, Y, nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);

            return CreateWindowExA(dwExStyle, lpClassName, lpWindowName, dwStyle, X, Y, nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UpdateWindow(
            [In] HWND hwnd
        );

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool ShowWindow(
            [In] HWND hWnd,
            [In] int  nCmdShow
        );

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool DestroyWindow(
          [In] HWND hWnd
        );

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool CloseWindow(
          [In] HWND hWnd
        );
    }
}
