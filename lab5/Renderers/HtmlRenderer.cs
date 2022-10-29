using Laboratory5.Interfaces;

namespace Laboratory5.Renderers
{
    public class HtmlRenderer: IRenderer
    {
        private IPage _page;

        public string Serialize()
        {
            return _page.SerializeToHtml();
        }

        public HtmlRenderer(IPage page)
        {
            _page = page;
        }
    }
}
