namespace MercadoOrion;

/// <summary>
/// Dados de um item na tabela produtos.
/// </summary>
public class ProductRecord
{
    public ProductRecord(int id, string name, double price, int quantity)
    {
        Id = id;
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public int Id { get; }
    public string Name { get; }
    public double Price { get; }
    public int Quantity { get; }

    public ProductRecord WithUpdates(string name, double price, int quantity) =>
        new(Id, name, price, quantity);
}
