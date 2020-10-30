namespace ePizza.WebApp.Model
{
    using System.Collections.Generic;
    using System.Linq;

    public class PizzaViewModel
    {
        public const int DEFAULT_SIZE = 30;
        public readonly int MINIMUM_SIZE = 20;
        public readonly int MAXIMUM_SIZE = 40;
        public readonly int INCREMENT_SIZE = 2;

        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Size { get; set; }
        public PizzaSpecialViewModel Special { get; set; }
        public int SpecialId { get; set; }
        public List<PizzaToppingViewModel> Toppings { get; set; }
        public decimal GetBasePrice() => ((decimal)Size / (decimal)DEFAULT_SIZE) * Special.BasePrice;
        public decimal GetTotalPrice() => GetBasePrice() + Toppings.Sum(t => t.Topping.Price);
        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
