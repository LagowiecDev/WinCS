project "WinCS"
    kind "SharedLib"
    language "C#"
    csversion "7.0"
    dotnetframework "net5.0"
    targetdir "bin/%{cfg.buildcfg}"
    objdir "obj/%{cfg.buildcfg}"

    files {
        "Source/**.cs"
    }

    filter "configurations:Debug"
        symbols "On"

    filter "configurations:Release"
        optimize "On"