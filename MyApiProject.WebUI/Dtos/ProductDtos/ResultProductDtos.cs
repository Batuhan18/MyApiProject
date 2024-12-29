namespace MyApiProject.WebUI.Dtos.ProductDtos
{
    public class ResultProductDtos
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public int price { get; set; }
        public string detail { get; set; }
        public string imageUrl { get; set; }
        public int categoryId { get; set; }
        public object category { get; set; }
    }
}


