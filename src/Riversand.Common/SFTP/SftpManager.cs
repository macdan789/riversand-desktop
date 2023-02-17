using Newtonsoft.Json.Linq;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using Riversand.Common.Configurations;
using Riversand.Common.Constatns;
using Riversand.Common.SFTP.Abstract;

namespace Riversand.Common.SFTP;

public class SftpManager : ISftpManager
{
    private readonly SftpClient _client;

    public SftpManager()
    {
        _client ??= new SftpClient(SftpConfiguration.Host, SftpConfiguration.Username, SftpConfiguration.Password);

        if (!_client.IsConnected)
            _client.Connect();
    }


    private Task<bool> IsDirectoryExist(string directory)
        => Task.FromResult(_client.Exists(directory));


    private Task DownloadFileAsync(string source, string destination)
        => Task.Run(() =>
        {
            using var destFile = File.OpenWrite(destination);
            _client.DownloadFile(source, destFile);
        });


    private static string GetDestFileName(SftpFile file, string productId)
        => SftpConfiguration.DownloadDir + string.Format(Constants.FILE_MASK, file.LastWriteTime.ToString(Constants.DATE_TIME_FORMAT), productId, file.Name);


    public void Dispose() => _client?.Dispose();


    public async Task<List<string>> GetFiles(string productId, DateTime start, DateTime end)
    {
        try
        {
            List<string> downloadedFiles = new();

            if (!await IsDirectoryExist(SftpConfiguration.WorkingDir))
                return downloadedFiles;

            List<SftpFile> files = (from file in _client.ListDirectory(SftpConfiguration.WorkingDir)
                                    where file.LastWriteTime >= start && file.LastWriteTime <= end
                                    select file).ToList();

            foreach (SftpFile file in files)
            {
                if (file.Name.EndsWith(Constants.JSON, StringComparison.CurrentCultureIgnoreCase))
                {
                    string fileContent = _client.ReadAllText(file.FullName);
                    var entity = JObject.Parse(fileContent);

                    string name = entity["name"]!.ToString();
                    string sku = entity["data"]!["attributes"]!["sku"]!["values"]!.First()["value"]!.ToString();

                    if (string.Equals(name, productId, StringComparison.CurrentCultureIgnoreCase)
                        || string.Equals(sku, productId, StringComparison.CurrentCultureIgnoreCase))
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
    }
}