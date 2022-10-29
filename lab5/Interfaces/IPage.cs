namespace Laboratory5.Interfaces
{
    public interface IPage
    {
        string SerializeToHtml();

        string SerializeTJson();

        string SerializeToXml();
    }
}
