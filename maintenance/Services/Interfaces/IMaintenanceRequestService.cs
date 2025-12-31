using maintenance.DTOs.MaintenanceRequest;

namespace maintenance.Services.Interfaces
{
    public interface IMaintenanceRequestService
    {
        Task<List<MaintenanceRequestResponseDto>> GetAllAsync();
        Task<MaintenanceRequestResponseDto?> GetByIdAsync(int id);
        Task<MaintenanceRequestResponseDto> CreateAsync(CreateMaintenanceRequestDto dto);
        Task<bool> CancelAsync(int id);
    }

}
