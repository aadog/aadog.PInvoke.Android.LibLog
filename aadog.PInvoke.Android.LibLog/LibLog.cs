using System.Runtime.InteropServices;
using aadog.PInvoke.Android.LibLog.Enums;

namespace aadog.PInvoke.Android.LibLog
{
    public partial struct LibLog
    {
        [LibraryImport("log")]
        public static partial int __android_log_print(android_LogPriority prio, [MarshalAs(UnmanagedType.LPUTF8Str)] string tag, [MarshalAs(UnmanagedType.LPUTF8Str)] string fmt);

        public static void Log(android_LogPriority priority, string tag, string msg)
        {
            __android_log_print(priority, tag, msg);
        }

        public static void LogInfo(string tag, string msg) => Log(android_LogPriority.ANDROID_LOG_INFO, tag, msg);
        public static void LogDebug(string tag, string msg) => Log(android_LogPriority.ANDROID_LOG_DEBUG, tag, msg);
        public static void LogError(string tag, string msg) => Log(android_LogPriority.ANDROID_LOG_ERROR, tag, msg);
        public static void LogFatal(string tag, string msg) => Log(android_LogPriority.ANDROID_LOG_FATAL, tag, msg);
        public static void LogWarn(string tag, string msg) => Log(android_LogPriority.ANDROID_LOG_WARN, tag, msg);
        public static void LogVerbose(string tag, string msg) => Log(android_LogPriority.ANDROID_LOG_VERBOSE, tag, msg);

        public static void LOG_INFO(string tag, string msg) => Log(android_LogPriority.ANDROID_LOG_INFO, tag, msg);
        public static void LOG_DEBUG(string tag, string msg) => Log(android_LogPriority.ANDROID_LOG_DEBUG, tag, msg);
        public static void LOG_ERROR(string tag, string msg) => Log(android_LogPriority.ANDROID_LOG_ERROR, tag, msg);
        public static void LOG_FATAL(string tag, string msg) => Log(android_LogPriority.ANDROID_LOG_FATAL, tag, msg);
        public static void LOG_WARN(string tag, string msg) => Log(android_LogPriority.ANDROID_LOG_WARN, tag, msg);
        public static void LOG_VERBOSE(string tag, string msg) => Log(android_LogPriority.ANDROID_LOG_VERBOSE, tag, msg);
    }
}
