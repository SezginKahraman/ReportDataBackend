using Microsoft.AspNetCore.Mvc;
using ReportDataBackend.Business.Abstract;
using ReportDataBackend.Entity.Concrete;

namespace ReportDataBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntraUserAccountController : ControllerBase
    {
        private readonly IEntraUserAccountService _entraUserAccountService;
        private readonly ILogger<EntraUserAccountController> _logger;

        public EntraUserAccountController(IEntraUserAccountService entraUserAccountService, ILogger<EntraUserAccountController> logger)
        {
            _entraUserAccountService = entraUserAccountService;
            _logger = logger;
        }

        [Route("get")]
        [HttpGet]
        public EntraUserAccount GetById(int id)
        {
            return _entraUserAccountService.GetById(id).Data;
        }

        [Route("getall")]
        [HttpGet]
        public List<EntraUserAccount> GetAll()
        {
            return _entraUserAccountService.GetAll().Data;
        }
    }
}
