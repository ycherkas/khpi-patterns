using Laboratory5.Interfaces;

namespace Laboratory5.Concrete
{
    public class ProductPage: IPage
    {
        private Product _product;

        public string SerializeTJson()
        {
            return $@"
{{
    'product': {{
        'id': '${_product.Id}',
        'name': '${_product.Name}',
        'description': '${_product.Description}',
        'imageUrl': '${_product.ImageUrl}',
    }}

}}
";
        }

        public string SerializeToHtml()
        {
            return $@"
<section data-id'{_product.Id}'>
    <h3>${_product.Name}'</h3>
    <p>${_product.Description}</p>
    <img strc='${_product.ImageUrl}'/>
</section>
";
        }

        public string SerializeToXml()
        {
            return $@"
<ProductPage>
    <Product>
        <Id>${_product.Id}'</Id>
        <Name>${_product.Name}</Name>
        <Description>${_product.Description}</Description>
        <ImageUrl>${_product.ImageUrl}</ImageUrl>
    </Product>
</ProductPage>
";
        }

        public ProductPage(Product product)
        {
            _product = product;
        }
    }
}
