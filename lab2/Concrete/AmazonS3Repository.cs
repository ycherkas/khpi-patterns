using Laboratory2.Interfaces;

namespace Laboratory2.Concrete
{
    public class AmazonS3Repository : IFileRepository
    {
        private static AmazonS3Repository _instance;

        public static IFileRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AmazonS3Repository();
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

        private AmazonS3Repository()
        {
        }
    }
}
