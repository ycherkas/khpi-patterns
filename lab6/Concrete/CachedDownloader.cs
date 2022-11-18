using Laboratory6.Interfaces;

namespace Laboratory6.Concrete
{
    public class CachedDownloader : IDownloader
    {
        private IDownloader _downloader;
        private Dictionary<string, object> _cache;

        public CachedDownloader(IDownloader downloader)
        {
            _downloader = downloader;
            _cache = new Dictionary<string, object>();
        }

        public object Download(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("path is required");

            if (_cache.ContainsKey(path)) return _cache[path];

            var file = _downloader.Download(path);

            _cache.Add(path, file);

            return file;
        }
    }
}
