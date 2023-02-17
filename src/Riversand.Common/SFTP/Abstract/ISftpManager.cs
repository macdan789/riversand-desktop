namespace Riversand.Common.SFTP.Abstract;

public interface ISftpManager : IDisposable
{
    Task<List<string>> GetFiles(string productId, DateTime start, DateTime end);
}