using Laboratory5.Interfaces;

namespace Laboratory5.Concrete
{
    public class SimplePage : IPage
    {
        private string _title;

        private string _content;

        public string SerializeTJson()
        {
            return $@"
{{
    'title': '${_title}',
    'content': '${_content}'
}}
";
        }

        public string SerializeToHtml()
        {
            return $@"
<section>
    <h3>${_title}'</h3>
    <p>${_content}</p>
</section>
";
        }

        public string SerializeToXml()
        {
            return $@"
<SimplePage>
    <Title>${_title}'</Title>
    <Content>${_content}</Content>
</SimplePage>
";
        }

        public SimplePage(string title, string content)
        {
            _title = title;
            _content = content;
        }
    }
}
