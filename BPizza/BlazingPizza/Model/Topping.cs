using System.Globalization;
namespace BlazingPizza;

public class Topping
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public string GetFormattedPrice() =>
        Price.ToString(
            "C",
            CultureInfo.GetCultureInfo("en-US") // ← SAME culture as all others
        );
}
