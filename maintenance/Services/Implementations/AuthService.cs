using maintenance.DTOs.Auth;
using maintenance.Models;
using maintenance.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace maintenance.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _context;
        private readonly IJwtService _jwtService;

        public AuthService(ApplicationDbContext context, IJwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        public async Task<AuthResponseDto?> LoginAsync(LoginDto dto)
        {
            // مثال: login على جدول Users (أو Admins)
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == dto.Email);

            if (user == null)
                return null;

            // ❌ مؤقت – بعدين نعمل hashing
          //  if (user.Password != dto.Password)
            //    return null;

            var token = _jwtService.GenerateToken(
                user.Id,
                user.UserName,
                user.Role
            );

            return new AuthResponseDto
            {
                UserId = user.Id,
                UserName = user.UserName,
                Role = user.Role,
                Token = token
            };
        }

        public async Task<string> RegisterAsync(RegisterDto dto)
        {
            var user = new User
            {
                UserName = dto.UserName,
                Email = dto.Email,
             //   Password = dto.Password, // hashing بعدين
                Role = dto.Role
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return "User registered successfully";
        }

        Task<AuthResponseDto> IAuthService.RegisterAsync(RegisterDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
