// See https://aka.ms/new-console-template for more information
WriteLine("There are {0} arguments", args.Length);


foreach (string arg in args)
{
    WriteLine(arg);
}

if (args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size e.g");
    WriteLine("dotnet run Red Yellow 5");

    return;
}

ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[0], ignoreCase: true);
BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[1], ignoreCase: true);

try
{
    CursorSize = int.Parse(s: args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("Setting CursorSize is not supported on this platform.");
}

if (OperatingSystem.IsWindows())
{
    WriteLine("This is Windows");
}
else if (OperatingSystem.IsLinux())
{
    WriteLine("This is Linux");
}
else if (OperatingSystem.IsMacOS())
{
    WriteLine("This is macOS");
}
else
{
    WriteLine("Unknown OS");
}

#if NET9_0_IOS
    WriteLine("This is iOS, this code only compiles on iOS!");
#elif NET8_0_IOS
    WriteLine("This is iOS, this code only compiles on iOS!");
#elif NET7_0_ANDROID
    WriteLine("This is Android, this code only compiles on Android!");
#elif MACOS
    WriteLine("Compiled specifically for macOS (MACOS symbol defined).");
#else
// seems to hit this believe there is ways to define symbols per OS/runtime but not set up here
    WriteLine($"Environment.Version: {Environment.Version}");
    WriteLine($"Environment.OSVersion: {Environment.OSVersion}");
#endif