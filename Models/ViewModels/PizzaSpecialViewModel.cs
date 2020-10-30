namespace ePizza.WebApp.Model
{
    public partial class AddPizzaSpecialViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal BasePrice { get; set; }
    }

    public partial class PizzaSpecialViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal BasePrice { get; set; }
        public string GetFormattedBasePrice() => BasePrice.ToString("0.00");
    }
}
