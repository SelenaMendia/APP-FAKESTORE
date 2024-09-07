namespace Tp5_AppFakeStore.Models;

public class Producto
{
    public int id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public decimal price { get; set; }
    public string category { get; set; }
    public string image { get; set; }
    public Rating rating { get; set; }

    public string Categoria
    {
        get
        {
            return $"{Capitalize(category)}";
        }
    }

    private string Capitalize(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return value;

        return string.Join(" ", value.Split(' ')
                                     .Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
    }
}
