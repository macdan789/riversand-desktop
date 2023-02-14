using System.Configuration;

namespace Riversand.Common.SFTP;

public static class SftpConfiguration
{
    public static string Host => ConfigurationManager.AppSettings.Get("SftpHost") ?? "";
    public static string Username => ConfigurationManager.AppSettings.Get("SftpUsername") ?? "";
    public static string Password => ConfigurationManager.AppSettings.Get("SftpPassword") ?? "";
    public static string WorkingDir => ConfigurationManager.AppSettings.Get("WorkingDir") ?? "";
    public static string DownloadDir => ConfigurationManager.AppSettings.Get("DownloadDir") ?? "";
}
