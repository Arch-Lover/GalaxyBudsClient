using System.Runtime.InteropServices;

namespace GalaxyBudsClient.Platform.Windows
{
    public static class WindowsUtils
    {
        [DllImport("kernel32", SetLastError = true)]
        private static extern bool AttachConsole(int dwProcessId);

        public static void AttachConsole()
        {
            AttachConsole(-1);
        }
    }
}