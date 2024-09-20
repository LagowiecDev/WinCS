using System;
using System.Runtime.InteropServices;

namespace WinCS
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WNDCLASS
    {
        public DWORD style;
        public WNDPROC lpfnWndProc; // Pointer to the window procedure
        public int cbClsExtra; // Extra class memory
        public int cbWndExtra; // Extra window memory
        public HINSTANCE hInstance; // Handle to the instance
        public HICON hIcon; // Handle to the class icon
        public HCURSOR hCursor; // Handle to the class cursor
        public HBRUSH hbrBackground; // Handle to the class background brush
        public string lpszMenuName; // Name of the menu resource
        public string lpszClassName; // Name of the window class

        // Implicit conversion to WNDCLASSW
        public static implicit operator WNDCLASSW(WNDCLASS wndClass)
        {
            return new WNDCLASSW
            {
                style = wndClass.style,
                lpfnWndProc = wndClass.lpfnWndProc,
                cbClsExtra = wndClass.cbClsExtra,
                cbWndExtra = wndClass.cbWndExtra,
                hInstance = wndClass.hInstance,
                hIcon = wndClass.hIcon,
                hCursor = wndClass.hCursor,
                hbrBackground = wndClass.hbrBackground,
                lpszMenuName = wndClass.lpszMenuName, // Assuming this is a Unicode string
                lpszClassName = wndClass.lpszClassName // Assuming this is a Unicode string
            };
        }

        // Implicit conversion to WNDCLASSA
        public static implicit operator WNDCLASSA(WNDCLASS wndClass)
        {
            return new WNDCLASSA
            {
                style = wndClass.style,
                lpfnWndProc = wndClass.lpfnWndProc,
                cbClsExtra = wndClass.cbClsExtra,
                cbWndExtra = wndClass.cbWndExtra,
                hInstance = wndClass.hInstance,
                hIcon = wndClass.hIcon,
                hCursor = wndClass.hCursor,
                hbrBackground = wndClass.hbrBackground,
                lpszMenuName = new LPCSTR(wndClass.lpszMenuName), // Convert to LPCSTR
                lpszClassName = new LPCSTR(wndClass.lpszClassName) // Convert to LPCSTR
            };
        }
    }
}