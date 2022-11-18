using Laboratory6.Interfaces;

namespace Laboratory6.Concrete
{
    public class SimpleDownloader : IDownloader
    {
        public object Download(string path)
        {
            //TODO: make call to remote service to download real file
            return new
            {
                Id = path,
                LastSyncDate = DateTime.Now,
            };
        }
    }
}
