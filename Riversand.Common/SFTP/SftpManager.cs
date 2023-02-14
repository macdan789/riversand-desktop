using Renci.SshNet;
using Renci.SshNet.Sftp;

namespace Riversand.Common.SFTP;

public class SftpManager
{
    private const string JSON = ".json";
    private const string FILE_MASK = "{0}_{1}_{2}";

    private readonly SftpClient _client;

    public SftpManager()
    {
        _client = new SftpClient(SftpConfiguration.Host, SftpConfiguration.Username, SftpConfiguration.Password);
    }

    private Task<bool> IsDirectoryExist(string directory)
        => Task.FromResult(_client.Exists(directory));

    private Task DownloadFileAsync(string source, string destination)
    {
        return Task.Run(() =>
        {
            using var destFile = File.OpenWrite(destination);
            _client.DownloadFile(source, destFile);
        });
    }

    private string GetDestFileName(SftpFile file, string productId)
        => SftpConfiguration.DownloadDir + string.Format(FILE_MASK, file.LastWriteTime.ToString("MM-dd-yyyy-HH-mm-ss"), productId.ToUpper(), file.Name);

    private void Dispose() => _client?.Dispose();

    public async Task<List<string>> GetFiles(string productId, DateTime start, DateTime end)
    {
        try
        {
            List<string> downloadedFiles = new();
            _client.Connect();

            if (!await IsDirectoryExist(SftpConfiguration.WorkingDir))
                return downloadedFiles;

            List<SftpFile> files = (from file in _client.ListDirectory(SftpConfiguration.WorkingDir)
                                    where file.LastWriteTime >= start && file.LastWriteTime <= end
                                    select file).ToList();

            foreach (SftpFile file in files)
            {
                if (file.Name.EndsWith(JSON, StringComparison.CurrentCultureIgnoreCase))
                {
                    string fileContent = _client.ReadAllText(file.FullName);
                    if (fileContent.Contains(productId, StringComparison.CurrentCultureIgnoreCase))
                    {
                        string destFileName = GetDestFileName(file, productId);
                        await DownloadFileAsync(file.FullName, destFileName);
                        downloadedFiles.Add(Path.GetFileName(destFileName));
                    }
                }
            }

            return downloadedFiles;
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            Dispose();
        }
    }
}