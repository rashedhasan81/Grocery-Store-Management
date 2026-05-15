using System;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;

public static class DatabaseHelper
{
    public static SqlConnection GetConnection()
    {
        // Replace with your actual connection string
        var connectionString = "YourConnectionStringHere";
        return new SqlConnection(connectionString);
    }
}

public static class SuperAdminSeeder
{
    private const int Iterations = 100_000;
    private const int SaltSize = 16;
    private const int HashSize = 32;

    public static void Seed(string username, string password)
    {
        var salt = RandomNumberGenerator.GetBytes(SaltSize);
        using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
        var hash = pbkdf2.GetBytes(HashSize);

        var hashB64 = Convert.ToBase64String(hash);
        var saltB64 = Convert.ToBase64String(salt);

        using var con = DatabaseHelper.GetConnection();
        con.Open();
        const string sql = "INSERT INTO SuperAdmins (Username, PasswordHash, PasswordSalt, Iterations) VALUES (@u, @h, @s, @i)";
        using var cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@u", username);
        cmd.Parameters.AddWithValue("@h", hashB64);
        cmd.Parameters.AddWithValue("@s", saltB64);
        cmd.Parameters.AddWithValue("@i", Iterations);
        cmd.ExecuteNonQuery();
    }
}