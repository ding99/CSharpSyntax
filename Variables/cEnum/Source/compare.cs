using System;

namespace CEnum {
	public enum LogType {
        All,
        Console,
        Slack
    }

    public enum LogLevel {
        Info,
        Warn,
        Error,
    }

    public class Logging {
        public static string LogAllInfo = "AllInfo";
        public static string LogAllWarn = "AllWarn";
        public static string LogAllError = "AllError";

        public static string LogConsoleInfo = "ConsoleInfo";
        public static string LogConsoleWarn = "ConsoleWarn";
        public static string LogConsoleError = "ConsoleError";

        public static string LogSlackInfo = "SlackInfo";
        public static string LogSlackWarn = "SlackWarn";
        public static string LogSlackError = "SlackError";
    }

    public class Compare {
        private string prev(LogType type = LogType.All, LogLevel level = LogLevel.Info) {

            string key = string.Empty;
            switch(type) {
            case LogType.Console:
                switch(level) {
                case LogLevel.Warn:
                    key = Logging.LogConsoleWarn;
                    break;
                case LogLevel.Error:
                    key = Logging.LogConsoleError;
                    break;
                default:
                    key = Logging.LogConsoleInfo;
                    break;
                }
                break;
            case LogType.Slack:
                switch(level) {
                case LogLevel.Warn:
                    key = Logging.LogSlackWarn;
                    break;
                case LogLevel.Error:
                    key = Logging.LogSlackError;
                    break;
                default:
                    key = Logging.LogSlackInfo;
                    break;
                }
                break;
            default:
                switch(level) {
                case LogLevel.Warn:
                    key = Logging.LogAllWarn;
                    break;
                case LogLevel.Error:
                    key = Logging.LogAllError;
                    break;
                default:
                    key = Logging.LogAllInfo;
                    break;
                }
                break;
            }

            return key;
        }

        private string newr(LogType type = LogType.All, LogLevel level = LogLevel.Info) {

            string key = level == LogLevel.Warn ? Logging.LogAllWarn : level == LogLevel.Error ? Logging.LogAllError : Logging.LogAllInfo;
            switch(type) {
            case LogType.Console:
                key = level == LogLevel.Warn ? Logging.LogConsoleWarn : level == LogLevel.Error ? Logging.LogConsoleError : Logging.LogConsoleInfo;
                break;
            case LogType.Slack:
                key = level == LogLevel.Warn ? Logging.LogSlackWarn : level == LogLevel.Error ? Logging.LogSlackError : Logging.LogSlackInfo;
                break;
            }

            return key;
        }

        private void pair(LogType type, LogLevel level) {
            Console.WriteLine($"{type} / {level} -> {prev(type, level)} / {newr(type, level)}");
        }
        public void start() {
            pair(LogType.All, LogLevel.Info);
            pair(LogType.All, LogLevel.Warn);
            pair(LogType.All, LogLevel.Error);
            pair(LogType.Console, LogLevel.Info);
            pair(LogType.Console, LogLevel.Warn);
            pair(LogType.Console, LogLevel.Error);
            pair(LogType.Slack, LogLevel.Info);
            pair(LogType.Slack, LogLevel.Warn);
            pair(LogType.Slack, LogLevel.Error);
        }

        public void greater() {
            Console.WriteLine($"info > warn,  [{LogLevel.Info > LogLevel.Warn}]");
            Console.WriteLine($"info > error, [{LogLevel.Info > LogLevel.Error}]");
            Console.WriteLine($"warn > error, [{LogLevel.Warn > LogLevel.Error}]");

            Console.WriteLine($"warn  > info, [{LogLevel.Warn > LogLevel.Info}]");
            Console.WriteLine($"error > info, [{LogLevel.Error > LogLevel.Info}]");
            Console.WriteLine($"error > warn, [{LogLevel.Error > LogLevel.Warn}]");

            Console.WriteLine($"warn  >= info, [{LogLevel.Warn >= LogLevel.Info}]");
            Console.WriteLine($"error >= info, [{LogLevel.Error >= LogLevel.Info}]");
            Console.WriteLine($"error >= warn, [{LogLevel.Error >= LogLevel.Warn}]");
            Console.WriteLine($"warn  >= warn, [{LogLevel.Warn  >= LogLevel.Warn}]");

            Console.WriteLine(Environment.NewLine + "-- equal --");
            Console.WriteLine($"warn > warn, [{LogLevel.Warn > LogLevel.Warn}]");
            Console.WriteLine($"warn = warn, [{LogLevel.Warn == LogLevel.Warn}]");
        }
    }
}
