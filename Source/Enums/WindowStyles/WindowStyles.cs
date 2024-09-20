namespace WinCS
{
    public static partial class WindowStylesFlags
    {
        public const uint WS_BORDER = 0x00800000;             // The window has a thin-line border.
        public const uint WS_CAPTION = 0x00C00000;            // The window has a title bar (includes the WS_BORDER style).
        public const uint WS_CHILD = 0x40000000;              // The window is a child window.
        public const uint WS_CHILDWINDOW = WS_CHILD;          // Same as WS_CHILD.
        public const uint WS_CLIPCHILDREN = 0x02000000;      // Excludes the area occupied by child windows when drawing.
        public const uint WS_CLIPSIBLINGS = 0x04000000;      // Clips child windows relative to each other.
        public const uint WS_DISABLED = 0x08000000;           // The window is initially disabled.
        public const uint WS_DLGFRAME = 0x00400000;           // The window has a border typically used with dialog boxes.
        public const uint WS_GROUP = 0x00020000;              // The window is the first control of a group of controls.
        public const uint WS_HSCROLL = 0x00100000;            // The window has a horizontal scroll bar.
        public const uint WS_ICONIC = 0x20000000;             // The window is initially minimized (same as WS_MINIMIZE).
        public const uint WS_MAXIMIZE = 0x01000000;           // The window is initially maximized.
        public const uint WS_MAXIMIZEBOX = 0x00010000;        // The window has a maximize button.
        public const uint WS_MINIMIZE = 0x20000000;           // The window is initially minimized (same as WS_ICONIC).
        public const uint WS_MINIMIZEBOX = 0x00020000;        // The window has a minimize button.
        public const uint WS_OVERLAPPED = 0x00000000;         // The window is an overlapped window.
        public const uint WS_OVERLAPPEDWINDOW =
            WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX; // Overlapped window with borders and buttons.
        public const uint WS_POPUP = 0x80000000;               // The window is a pop-up window.
        public const uint WS_POPUPWINDOW =
            WS_POPUP | WS_BORDER | WS_SYSMENU;                // A pop-up window with a border and menu.
        public const uint WS_SIZEBOX = 0x00040000;            // The window has a sizing border (same as WS_THICKFRAME).
        public const uint WS_SYSMENU = 0x00080000;            // The window has a window menu on its title bar.
        public const uint WS_TABSTOP = 0x00010000;            // The window is a control that can receive keyboard focus.
        public const uint WS_THICKFRAME = 0x00040000;         // The window has a sizing border (same as WS_SIZEBOX).
        public const uint WS_TILED = 0x00000000;               // The window is an overlapped window.
        public const uint WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW; // Overlapped window (same as WS_OVERLAPPEDWINDOW).
        public const uint WS_VISIBLE = 0x10000000;             // The window is initially visible.
        public const uint WS_VSCROLL = 0x00200000;            // The window has a vertical scroll bar.
    }
}