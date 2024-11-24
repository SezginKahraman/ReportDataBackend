using Microsoft.AspNetCore.Mvc;
using ReportDataBackend.Business.Abstract;
using ReportDataBackend.Entity.Concrete;

namespace ReportDataBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntraGroupsController : ControllerBase
    {
        private readonly IEntraGroupService _entraGroupService;
        private readonly ILogger<EntraGroupsController> _logger;


        public EntraGroupsController(IEntraGroupService entraGroupService, ILogger<EntraGroupsController> logger)
        {
            _entraGroupService = entraGroupService;
            _logger = logger;
        }

        [Route("get")]
        [HttpGet]
        public EntraGroup GetById(string id)
        {
            return _entraGroupService.GetById(id).Data;
        }

        [Route("getall")]
        [HttpGet]
        public List<EntraGroup> GetAll()
        {
            return _entraGroupService.GetAll().Data;
        }
    }
}
