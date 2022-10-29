using Laboratory5.Interfaces;

namespace Laboratory5.Renderers
{
    public class XmlRenderer: IRenderer
    {
        private IPage _page;

        public string Serialize()
        {
            return _page.SerializeToXml();
        }

        public XmlRenderer(IPage page)
        {
            _page = page;
        }
    }
}
