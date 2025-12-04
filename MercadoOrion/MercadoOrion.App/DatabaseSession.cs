using Npgsql;

namespace MercadoOrion;

/// <summary>
/// Gerencia a string de conexão ativa e abre conexões prontas para uso.
/// </summary>
public static class DatabaseSession
{
    private static string? _connectionString;

    public static bool HasConnection => !string.IsNullOrWhiteSpace(_connectionString);

    public static void Configure(string host, int port, string user, string password, string database)
    {
        if (string.IsNullOrWhiteSpace(host) ||
            string.IsNullOrWhiteSpace(user) ||
            string.IsNullOrWhiteSpace(database))
        {
            throw new InvalidOperationException("Host, usuário e banco são obrigatórios.");
        }

        _connectionString = $"Host={host};Port={port};Username={user};Password={password};Database={database}";
    }

    public static void Reset()
    {
        _connectionString = null;
    }

    public static void TestConnection()
    {
        using var conn = OpenConnection();
        using var cmd = new NpgsqlCommand("SELECT 1", conn);
        _ = cmd.ExecuteScalar();
    }

    public static NpgsqlConnection OpenConnection()
    {
        if (!HasConnection)
        {
            throw new InvalidOperationException("Configure a conexão antes de prosseguir.");
        }

        var connection = new NpgsqlConnection(_connectionString);
        connection.Open();
        return connection;
    }
}
