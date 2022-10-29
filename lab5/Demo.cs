using Laboratory5.Concrete;
using Laboratory5.Renderers;

namespace Laboratory5
{
    public class Demo
    {
        public void Run()
        {
            var client = new Client();

            var simplePage = new SimplePage("Title", "Content");
            var product = new Product()
            {
                Id = 1,
                Name = "Super Product",
                Description = "You need this product!",
                ImageUrl = "https://test.com/image.jpeg"
            };
            var productPage = new ProductPage(product);

            var htmlRenderer1 = new HtmlRenderer(simplePage);
            client.Render(htmlRenderer1);

            var htmlRenderer2 = new HtmlRenderer(productPage);
            client.Render(htmlRenderer2);

            var jsonRenderer = new JsonRenderer(simplePage);
            client.Render(jsonRenderer);

            var xmlRenderer = new XmlRenderer(productPage);
            client.Render(xmlRenderer);
        }
    }
}