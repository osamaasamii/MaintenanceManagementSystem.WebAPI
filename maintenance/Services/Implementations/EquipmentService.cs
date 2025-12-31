using maintenance.DTOs.Equipment;
using maintenance.Models;
using maintenance.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace maintenance.Services.Implementations
{
    public class EquipmentService : IEquipmentService
    {
        private readonly ApplicationDbContext _context;

        public EquipmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        // CREATE
        public async Task<EquipmentResponseDto> CreateAsync(EquipmentCreateDto dto)
        {
            var equipment = new Equipment
            {
                Name = dto.Name,
                Model = dto.Model,
                SerialNumber = dto.SerialNumber
            };

            _context.Equipments.Add(equipment);
            await _context.SaveChangesAsync();

            return new EquipmentResponseDto
            {
                Id = equipment.Id,
                Name = equipment.Name,
                Model = equipment.Model,
                SerialNumber = equipment.SerialNumber
            };
        }

        // GET ALL
        public async Task<List<EquipmentResponseDto>> GetAllAsync()
        {
            return await _context.Equipments
                .Select(e => new EquipmentResponseDto
                {
                    Id = e.Id,
                    Name = e.Name,
                    Model = e.Model,
                    SerialNumber = e.SerialNumber
                }).ToListAsync();
        }

        // GET BY ID
        public async Task<EquipmentResponseDto?> GetByIdAsync(int id)
        {
            var equipment = await _context.Equipments.FindAsync(id);

            if (equipment == null)
                return null;

            return new EquipmentResponseDto
            {
                Id = equipment.Id,
                Name = equipment.Name,
                Model = equipment.Model,
                SerialNumber = equipment.SerialNumber
            };
        }

        // DELETE
        public async Task<bool> DeleteAsync(int id)
        {
            var equipment = await _context.Equipments.FindAsync(id);

            if (equipment == null)
                return false;

            _context.Equipments.Remove(equipment);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
