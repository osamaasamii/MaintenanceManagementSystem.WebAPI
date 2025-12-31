using maintenance.DTOs.Technician;

namespace maintenance.Services.Interfaces
{
    public interface ITechnicianService
    {
        Task<List<TechnicianResponseDto>> GetAllAsync();
        Task<TechnicianResponseDto?> GetByIdAsync(int id);
        Task<TechnicianResponseDto> CreateAsync(TechnicianCreateDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
