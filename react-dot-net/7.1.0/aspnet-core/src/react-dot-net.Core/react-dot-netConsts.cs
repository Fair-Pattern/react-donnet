using react-dot-net.Debugging;

namespace react-dot-net
{
    public class react-dot-netConsts
    {
        public const string LocalizationSourceName = "react-dot-net";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "06840d86b54e4c758e1f4f669457e57d";
    }
}
