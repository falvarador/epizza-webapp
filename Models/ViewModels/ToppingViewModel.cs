namespace ePizza.WebApp.Model
{
    public class ToppingViewModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string GetFormattedPrice() => Price.ToString("0.00");
    }
}
