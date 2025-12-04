using Npgsql;

namespace MercadoOrion;

/// <summary>
/// Operações CRUD usando a tabela produtos.
/// </summary>
public static class ProductRepository
{
    public static IReadOnlyList<ProductRecord> GetAll()
    {
        var produtos = new List<ProductRecord>();
        using var conn = DatabaseSession.OpenConnection();
        using var cmd = new NpgsqlCommand("SELECT id, nome, valor, quantidade FROM produtos ORDER BY id", conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            var id = reader.GetInt32(0);
            var nome = reader.GetString(1);
            var valor = reader.GetDouble(2);
            var quantidade = reader.GetInt32(3);
            produtos.Add(new ProductRecord(id, nome, valor, quantidade));
        }
        return produtos;
    }

    public static ProductRecord Insert(string name, double price, int quantity)
    {
        using var conn = DatabaseSession.OpenConnection();
        using var cmd = new NpgsqlCommand("INSERT INTO produtos (nome, valor, quantidade) VALUES (@nome, @valor, @quantidade) RETURNING id;", conn);
        cmd.Parameters.AddWithValue("nome", name);
        cmd.Parameters.AddWithValue("valor", price);
        cmd.Parameters.AddWithValue("quantidade", quantity);

        var id = Convert.ToInt32(cmd.ExecuteScalar());
        return new ProductRecord(id, name, price, quantity);
    }

    public static void Update(ProductRecord produto)
    {
        using var conn = DatabaseSession.OpenConnection();
        using var cmd = new NpgsqlCommand("UPDATE produtos SET nome = @nome, valor = @valor, quantidade = @quantidade WHERE id = @id;", conn);
        cmd.Parameters.AddWithValue("nome", produto.Name);
        cmd.Parameters.AddWithValue("valor", produto.Price);
        cmd.Parameters.AddWithValue("quantidade", produto.Quantity);
        cmd.Parameters.AddWithValue("id", produto.Id);
        cmd.ExecuteNonQuery();
    }

    public static void Delete(int id)
    {
        using var conn = DatabaseSession.OpenConnection();
        using var cmd = new NpgsqlCommand("DELETE FROM produtos WHERE id = @id;", conn);
        cmd.Parameters.AddWithValue("id", id);
        cmd.ExecuteNonQuery();
    }
}
