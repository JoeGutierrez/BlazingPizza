namespace BlazingPizza
{
    /// <summary>
    /// Represents a pre-configured template for a pizza a user can order
    /// </summary>
    public class PizzaSpecial
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal BasePrice { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string GetFormattedBasePrice() => BasePrice.ToString("0.00"); // Lambda expressions and anonymous functions https://stackoverflow.com/questions/4829054/what-does-this-c-sharp-code-with-an-arrow-an-equal-sign-and-greater-than#52426208 https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions Added: 11/28/2023.
    }
}
