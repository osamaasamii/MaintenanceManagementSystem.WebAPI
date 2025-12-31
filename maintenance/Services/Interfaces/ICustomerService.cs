using maintenance.DTOs.Customer;

namespace maintenance.Services.Interfaces
{
    public interface ICustomerService
    {

        Task<List<CustomerResponseDto>> GetAllAsync();
        Task<CustomerResponseDto?> GetByIdAsync(int id);
        Task<CustomerResponseDto> CreateAsync(CustomerCreateDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
