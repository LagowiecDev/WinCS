using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCS
{
    public static partial class ShowWindowFlags
    {
        public const int SW_HIDE = 0;                     // Hides the window and activates another window.
        public const int SW_SHOWNORMAL = 1;               // Activates and displays a window.
        public const int SW_SHOWMINIMIZED = 2;            // Activates the window and displays it as a minimized window.
        public const int SW_SHOWMAXIMIZED = 3;            // Activates the window and displays it as a maximized window.
        public const int SW_SHOWNOACTIVATE = 4;           // Displays a window without activating it.
        public const int SW_SHOW = 5;                      // Activates the window and displays it in its current size and position.
        public const int SW_MINIMIZE = 6;                  // Minimizes the specified window and activates the next top-level window.
        public const int SW_SHOWMINNOACTIVE = 7;           // Displays the window as a minimized window without activating it.
        public const int SW_SHOWNA = 8;                    // Displays the window without activating it.
        public const int SW_RESTORE = 9;                   // Activates and displays the window, restoring it if necessary.
        public const int SW_SHOWDEFAULT = 10;              // Sets the show state based on the SW_ value in STARTUPINFO.
        public const int SW_FORCEMINIMIZE = 11;            // Minimizes the window, forcing it to minimize even if the window is not responding.
    }
}
