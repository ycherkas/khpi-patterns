using Laboratory5.Interfaces;

namespace Laboratory5.Renderers
{
    public class JsonRenderer: IRenderer
    {
        private IPage _page;

        public string Serialize()
        {
            return _page.SerializeTJson();
        }

        public JsonRenderer(IPage page)
        {
            _page = page;
        }
    }
}
