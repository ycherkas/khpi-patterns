using Laboratory2.Interfaces;

namespace Laboratory2.Concrete
{
    public class LocalDiskRepository : IFileRepository
    {
        private static IFileRepository _instance;

        public static IFileRepository GetInstance()
        {
            if(_instance == null)
            {
                _instance = new LocalDiskRepository();
            }

            return _instance;
        }

        public object Read(string path)
        {
            throw new NotImplementedException();
        }

        public void Write(string path, object value)
        {
            throw new NotImplementedException();
        }

        private LocalDiskRepository()
        {
        }
    }
}
