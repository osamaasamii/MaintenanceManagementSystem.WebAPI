using maintenance.DTOs.Assignment;

namespace maintenance.Services.Interfaces
{
    public interface IAssignmentService
    {
        // اسناد فني لطلب صيانة
        Task<AssignmentResponseDto> CreateAsync(AssignmentCreateDto dto);

        // كل الفنيين المسندين لطلب معين
        Task<List<AssignmentResponseDto>> GetByRequestIdAsync(int maintenanceRequestId);

        // الغاء / قفل اسناد
        Task<bool> CancelAsync(int assignmentId);
    }
}
