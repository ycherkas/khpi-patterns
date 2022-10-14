namespace Laboratory2.Interfaces
{
    public interface IFileRepository
    {
        object Read(string path);

        void Write(string path, object value);
    }
}
