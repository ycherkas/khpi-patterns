using Laboratory6.Concrete;
using Laboratory6.Interfaces;

namespace Laboratory6
{
    public class Demo
    {
        public void Run()
        {
            IDownloader downloader = new SimpleDownloader();
            IDownloader cachedDownloader = new CachedDownloader(downloader);

            var client = new Client();
            client.ProcessDownload(cachedDownloader, "https://site.com/file1");
            client.ProcessDownload(cachedDownloader, "https://site.com/file2");
            //file1 is taken from internal cache
            client.ProcessDownload(cachedDownloader, "https://site.com/file1");
        }
    }
}