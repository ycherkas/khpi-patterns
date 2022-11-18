using Laboratory6.Interfaces;

namespace Laboratory6
{
    public class Client
    {
        public void ProcessDownload(IDownloader downloader, string path)
        {
            var file = downloader.Download(path);

            //TODO: do something usefull with file
        }
    }
}
