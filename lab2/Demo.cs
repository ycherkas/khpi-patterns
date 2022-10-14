namespace Laboratory2
{
    public class Demo
    {
        public void Run()
        {
            var amazonS3Repository = FileManager.GetRepository(StorageType.AmazonS3);
            var localDiskRepository = FileManager.GetRepository(StorageType.LocalDisk);

            var file = amazonS3Repository.Read("S3/test.csv");
            localDiskRepository.Write("C:/test.csv", file);
        }
    }
}
