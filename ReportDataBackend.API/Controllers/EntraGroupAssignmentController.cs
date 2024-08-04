using Microsoft.AspNetCore.Mvc;
using ReportDataBackend.Business.Abstract;
using ReportDataBackend.Entity.Concrete;

namespace ReportDataBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntraGroupAssignmentController : ControllerBase
    {
        private readonly IEntraGroupAssignmentService _entraGroupAssignmentService;
        private readonly ILogger<EntraGroupAssignmentController> _logger;

        public EntraGroupAssignmentController(IEntraGroupAssignmentService entraGroupAssignmentService, ILogger<EntraGroupAssignmentController> logger)
        {
            _entraGroupAssignmentService = entraGroupAssignmentService;
            _logger = logger;
        }

        [Route("get")]
        [HttpGet]
        public EntraGroupAssignment GetById(int id)
        {
            return _entraGroupAssignmentService.GetById(id).Data;
        }

        [Route("getall")]
        [HttpGet]
        public List<EntraGroupAssignment> GetAll()
        {
            return _entraGroupAssignmentService.GetAll().Data;
        }
    }
}
