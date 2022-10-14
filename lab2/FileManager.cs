using Laboratory2.Concrete;
using Laboratory2.Interfaces;

namespace Laboratory2
{
    public class FileManager
    {
        public static IFileRepository GetRepository(StorageType storageType)
        {
            switch(storageType)
            {
                case StorageType.AmazonS3:
                    return AmazonS3Repository.GetInstance();
                case StorageType.LocalDisk:
                    return LocalDiskRepository.GetInstance();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}