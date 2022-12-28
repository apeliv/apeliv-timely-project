using Timely.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Timely.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly TimelyContext _context;

        public ProjectsController(TimelyContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetProjects() 
        {
            return Ok(await _context.Projects.ToListAsync());
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateProject(ProjectRequest projectRequest)
        {
            var project = new Project()
            {
                Id = new int(),
                ProjectName = projectRequest.ProjectName,
                StartTime = projectRequest.StartTime,
                EndTime=projectRequest.EndTime,
                Duration=projectRequest.Duration
            };
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();

            return Ok(project);

        }
    } 
}
