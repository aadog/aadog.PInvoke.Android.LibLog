using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aadog.PInvoke.Android.LibLog.Enums
{
    public enum android_LogPriority
    {
        ANDROID_LOG_UNKNOWN = 0,
        ANDROID_LOG_DEFAULT,    /* only for SetMinPriority() */
        ANDROID_LOG_VERBOSE,
        ANDROID_LOG_DEBUG,
        ANDROID_LOG_INFO,
        ANDROID_LOG_WARN,
        ANDROID_LOG_ERROR,
        ANDROID_LOG_FATAL,
        ANDROID_LOG_SILENT,     /* only for SetMinPriority(); must be last */
    }
}
