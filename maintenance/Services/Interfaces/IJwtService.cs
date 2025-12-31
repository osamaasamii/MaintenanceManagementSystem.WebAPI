using maintenance.Models;

public interface IJwtService
{

    string GenerateToken(int userId, string userName, string role);
}
