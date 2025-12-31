using maintenance.DTOs.Equipment;

namespace maintenance.Services.Interfaces
{
    public interface IEquipmentService
    {
        Task<List<EquipmentResponseDto>> GetAllAsync();
        Task<EquipmentResponseDto?> GetByIdAsync(int id);
        Task<EquipmentResponseDto> CreateAsync(EquipmentCreateDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
