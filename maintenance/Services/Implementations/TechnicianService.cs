using maintenance.DTOs.Technician;
using maintenance.Models;
using maintenance.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace maintenance.Services.Implementations
{
    public class TechnicianService : ITechnicianService
    {
        private readonly ApplicationDbContext _context;

        public TechnicianService(ApplicationDbContext context)
        {
            _context = context;
        }

    
        public async Task<List<TechnicianResponseDto>> GetAllAsync()
        {
            return await _context.Technicians
                .Select(t => new TechnicianResponseDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    Phone = t.Phone,
                    Specialization = t.Specialization
                })
                .ToListAsync();
        }

        public async Task<TechnicianResponseDto?> GetByIdAsync(int id)
        {
            var technician = await _context.Technicians.FindAsync(id);

            if (technician == null)
                return null;

            return new TechnicianResponseDto
            {
                Id = technician.Id,
                Name = technician.Name,
                Phone = technician.Phone,
                Specialization = technician.Specialization
            };
        }

        public async Task<TechnicianResponseDto> CreateAsync(TechnicianCreateDto dto)
        {
            var technician = new Technician
            {
                Name = dto.Name,
                Phone = dto.Phone,
                Specialization = dto.Specialization
            };

            _context.Technicians.Add(technician);
            await _context.SaveChangesAsync();

            return new TechnicianResponseDto
            {
                Id = technician.Id,
                Name = technician.Name,
                Phone = technician.Phone,
                Specialization = technician.Specialization
            };
        }

       
        public async Task<bool> DeleteAsync(int id)
        {
            var technician = await _context.Technicians.FindAsync(id);

            if (technician == null)
                return false;

            _context.Technicians.Remove(technician);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
