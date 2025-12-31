using maintenance.DTOs.MaintenanceRequest;
using maintenance.Enum;
using maintenance.Models;
using maintenance.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace maintenance.Services.Implementations
{
    public class MaintenanceRequestService : IMaintenanceRequestService
    {
        private readonly ApplicationDbContext _context;

        public MaintenanceRequestService(ApplicationDbContext context)
        {
            _context = context;
        }

        // CREATE
        public async Task<MaintenanceRequestResponseDto> CreateAsync(CreateMaintenanceRequestDto dto)
        {
            // 1️⃣ Check Customer exists
            var customerExists = await _context.Customers
                .AnyAsync(c => c.Id == dto.CustomerId);

            if (!customerExists)
                throw new Exception("Customer not found");

            // 2️⃣ Check Equipment exists
            var equipmentExists = await _context.Equipments
                .AnyAsync(e => e.Id == dto.EquipmentId);

            if (!equipmentExists)
                throw new Exception("Equipment not found");

            // 3️⃣ Create Request
            var request = new MaintenanceRequest
            {
                CustomerId = dto.CustomerId,
                EquipmentId = dto.EquipmentId,
                Description = dto.Description,
                Status = RequestStatus.Open,
                CreatedAt = DateTime.Now
            };

            _context.MaintenanceRequests.Add(request);
            await _context.SaveChangesAsync();

            return new MaintenanceRequestResponseDto
            {
                Id = request.Id,
                Description = request.Description,
                Status = request.Status.ToString(),
                CreatedAt = request.CreatedAt
            };
        }

        // GET ALL
        public async Task<List<MaintenanceRequestResponseDto>> GetAllAsync()
        {
            return await _context.MaintenanceRequests
                .Include(r => r.Customer)
                .Include(r => r.Equipment)
                .Select(r => new MaintenanceRequestResponseDto
                {
                    Id = r.Id,
                    CustomerName = r.Customer.Name,
                    EquipmentName = r.Equipment.Name,
                    Description = r.Description,
                    Status = r.Status.ToString(),
                    CreatedAt = r.CreatedAt
                }).ToListAsync();
        }

        // GET BY ID
        public async Task<MaintenanceRequestResponseDto?> GetByIdAsync(int id)
        {
            var request = await _context.MaintenanceRequests
                .Include(r => r.Customer)
                .Include(r => r.Equipment)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (request == null)
                return null;

            return new MaintenanceRequestResponseDto
            {
                Id = request.Id,
                CustomerName = request.Customer.Name,
                EquipmentName = request.Equipment.Name,
                Description = request.Description,
                Status = request.Status.ToString(),
                CreatedAt = request.CreatedAt
            };
        }

        // CANCEL
        public async Task<bool> CancelAsync(int id)
        {
            var request = await _context.MaintenanceRequests.FindAsync(id);

            if (request == null)
                return false;

            request.Status = RequestStatus.Cancelled;
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
