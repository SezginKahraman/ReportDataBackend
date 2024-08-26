using Microsoft.AspNetCore.Mvc;
using ReportDataBackend.Business.Abstract;
using ReportDataBackend.Entity.Concrete;

namespace ReportDataBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntraRoleController : ControllerBase
    {
        private readonly IEntraRoleService _entraRoleService;
        private readonly ILogger<EntraRoleController> _logger;


        public EntraRoleController(IEntraRoleService entraRoleService, ILogger<EntraRoleController> logger)
        {
            _entraRoleService = entraRoleService;
            _logger = logger;
        }

        [Route("get")]
        [HttpGet]
        public EntraRole GetById(string id)
        {
            return _entraRoleService.GetById(id).Data;
        }

        [Route("getall")]
        [HttpGet]
        public List<EntraRole> GetAll()
        {
            return _entraRoleService.GetAll().Data;
        }
    }
}
