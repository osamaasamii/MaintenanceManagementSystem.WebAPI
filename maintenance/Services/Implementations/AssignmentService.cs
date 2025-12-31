using maintenance.DTOs.Assignment;
using maintenance.Models;
using maintenance.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace maintenance.Services.Implementations
{
    public class AssignmentService : IAssignmentService
    {
        private readonly ApplicationDbContext _context;

        public AssignmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<AssignmentResponseDto> CreateAsync(AssignmentCreateDto dto)
        {
            var technician = await _context.Technicians.FindAsync(dto.TechnicianId);
            if (technician == null)
                throw new Exception("Technician not found");

            var request = await _context.MaintenanceRequests.FindAsync(dto.MaintenanceRequestId);
            if (request == null)
                throw new Exception("Maintenance request not found");

            var assignment = new Assignment
            {
                TechnicianId = dto.TechnicianId,
                MaintenanceRequestId = dto.MaintenanceRequestId,
                AssignedAt = DateTime.Now
            };

            _context.Assignments.Add(assignment);
            await _context.SaveChangesAsync();

            return new AssignmentResponseDto
            {
                Id = assignment.Id,
                TechnicianName = technician.Name,
                MaintenanceRequestId = request.Id,
                AssignedAt = assignment.AssignedAt
            };
        }

        public async Task<List<AssignmentResponseDto>> GetByRequestIdAsync(int maintenanceRequestId)
        {
            return await _context.Assignments
                .Include(a => a.Technician)
                .Where(a => a.MaintenanceRequestId == maintenanceRequestId)
                .Select(a => new AssignmentResponseDto
                {
                    Id = a.Id,
                    TechnicianName = a.Technician.Name,
                    MaintenanceRequestId = a.MaintenanceRequestId,
                    AssignedAt = a.AssignedAt
                })
                .ToListAsync();
        }

        public async Task<bool> CancelAsync(int assignmentId)
        {
            var assignment = await _context.Assignments.FindAsync(assignmentId);
            if (assignment == null)
                return false;

            _context.Assignments.Remove(assignment);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
