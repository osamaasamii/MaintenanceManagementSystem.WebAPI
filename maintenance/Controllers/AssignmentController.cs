using maintenance.DTOs.Assignment;
using maintenance.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace maintenance.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService _assignmentService;

        public AssignmentController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        // Assign technician to maintenance request
        [Authorize(Roles = "Admin")]
        [HttpPost("assign")]
        
        public async Task<IActionResult> Assign(AssignmentCreateDto dto)
        {
            await _assignmentService.CreateAsync(dto);
            return Ok("Technician assigned successfully");
        }

        // Get assignments by maintenance request id
        [HttpGet("by-request/{requestId}")]
        public async Task<IActionResult> GetByRequestId(int requestId)
        {
            var result = await _assignmentService.GetByRequestIdAsync(requestId);
            return Ok(result);
        }

    }
}
