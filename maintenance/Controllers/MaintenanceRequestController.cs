using maintenance.DTOs.MaintenanceRequest;
using maintenance.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace maintenance.Controllers
{
    [Authorize]
    
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceRequestController : ControllerBase
    {
        private readonly IMaintenanceRequestService _service;

        public MaintenanceRequestController(IMaintenanceRequestService service)
        {
            _service = service;
        }

        // POST: api/MaintenanceRequest
        [Authorize(Roles = "Customer")]
        
        [HttpPost]
        public async Task<IActionResult> Create(CreateMaintenanceRequestDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _service.CreateAsync(dto);
            return Ok(result);
        }

        // GET: api/MaintenanceRequest
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        // GET: api/MaintenanceRequest/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);

            if (result == null)
                return NotFound("Maintenance request not found");

            return Ok(result);
        }

        // PUT: api/MaintenanceRequest/5/cancel
        [HttpPut("{id}/cancel")]
        public async Task<IActionResult> Cancel(int id)
        {
            var cancelled = await _service.CancelAsync(id);

            if (!cancelled)
                return NotFound("Maintenance request not found");

            return Ok("Request cancelled");
        }
    }
}
