Here’s the updated documentation with three installation options:

---

### WinCS: C# Bindings for Windows API

**Overview:**
WinCS is a straightforward C# bindings library that provides direct access to essential Windows API functions from `user32.dll`, `kernel32.dll`, and other key Windows libraries. Designed for developers seeking raw, unwrapped access to native Windows functions, WinCS enables efficient interaction with the Windows operating system.

**Key Features:**

- **P/Invoke Bindings:** Access Windows API functions directly, such as `User32.CreateWindow()` and `Kernel32.GetModuleHandle()`, without additional abstraction layers.

- **Minimal Overhead:** Focused on performance and simplicity, providing direct bindings to Windows APIs for maximum efficiency.

- **Comprehensive Coverage:** Includes a wide range of functions from key DLLs, allowing developers to utilize various Windows functionalities.

- **Structured API Calls:** Clearly defined method signatures that mirror the native API, making it easy to use for those familiar with Windows programming.

**Installation:**
You can install WinCS using one of the following methods:

1. **Clone the GitHub Repository:**
   - Clone the repository directly from GitHub using the following command:
     ```bash
     git clone https://github.com/LagowiecDev/WinCS.git
     ```

2. **Download as a ZIP:**
   - Visit the [GitHub repository](https://github.com/LagowiecDev/WinCS) and download the package as a ZIP file. Extract the contents and add the necessary references to your project.

3. **Download as a NuGet Package:**
   - If available, you can download the NuGet package from the [releases section](https://github.com/LagowiecDev/WinCS/releases) of the GitHub repository. Install it via the NuGet Package Manager in Visual Studio or using the following command:
     ```bash
     dotnet add package WinCS
     ```

**Getting Started:**
Once installed, use the bindings to call Windows API functions directly in your C# code.

**Example Usage:**
```csharp
using WinCS;

static class Program
{
    private static LRESULT WindowProc(HWND hWnd, uint uMsg, WPARAM wParam, LPARAM lParam)
    {
        switch (uMsg)
        {
            case WindowMessagesFlags.WM_DESTROY:
                User32.PostQuitMessage(0);
                return 0;

            case WindowMessagesFlags.WM_CLOSE:
                User32.DestroyWindow(hWnd);
                break;
            // Handle other messages like WM_PAINT, WM_KEYDOWN, etc.
        }

        return User32.DefWindowProc(hWnd, uMsg, wParam, lParam);
    }

    static void Main()
    {
        const string CLASS_NAME = "Example Window Class";

        HINSTANCE hInstance = Kernel32.GetModuleHandle(null);

        WNDCLASS wc = new WNDCLASS
        {
            lpfnWndProc = WindowProc,
            lpszClassName = CLASS_NAME,
            hInstance = hInstance,
            style = WindowClassStylesFlags.CS_HREDRAW | WindowClassStylesFlags.CS_VREDRAW
        };

        // Register the window class
        User32.RegisterClass(wc);

        // Create the window
        HWND hWnd = User32.CreateWindowEx(
            0, CLASS_NAME, "Example Window", WindowStylesFlags.WS_OVERLAPPEDWINDOW,
            0, 0, 800, 600,
            Consts.NULL, Consts.NULL, hInstance, Consts.NULL
        );

        User32.ShowWindow(hWnd, SW_SHOW);
        User32.UpdateWindow(hWnd);

        MSG msg = new MSG();
        while (User32.GetMessage(ref msg, Consts.NULL, 0, 0))
        {
            User32.TranslateMessage(msg);
            User32.DispatchMessage(msg);
        }

        User32.DestroyWindow(hWnd);
        User32.UnregisterClass(wc, hInstance);
    }
}
```

**Conclusion:**
WinCS offers developers efficient bindings to the Windows API, making it an ideal choice for those looking to work closely with the Windows operating system without the overhead of additional layers.