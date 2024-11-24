using Microsoft.AspNetCore.Mvc;
using ReportDataBackend.Business.Abstract;
using ReportDataBackend.Entity.Concrete;

namespace ReportDataBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntraGroupModificationsController : ControllerBase
    {
        private readonly IEntraGroupModificationService _entraGroupModificationService;
        private readonly ILogger<EntraGroupModificationsController> _logger;


        public EntraGroupModificationsController(IEntraGroupModificationService entraGroupModificationService, ILogger<EntraGroupModificationsController> logger)
        {
            _entraGroupModificationService = entraGroupModificationService;
            _logger = logger;
        }

        [Route("get")]
        [HttpGet]
        public EntraGroupModification GetById(int id)
        {
            return _entraGroupModificationService.GetById(id).Data;
        }

        [Route("getall")]
        [HttpGet]
        public List<EntraGroupModification> GetAll()
        {
            return _entraGroupModificationService.GetAll().Data;
        }
    }
}
