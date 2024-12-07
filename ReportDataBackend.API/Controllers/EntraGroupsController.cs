using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReportDataBackend.Business.Abstract;
using ReportDataBackend.DataAccess.Abstract;
using ReportDataBackend.DataAccess.Concrete.EntityFramework;
using ReportDataBackend.Entity.Concrete;

namespace ReportDataBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntraGroupsController : ControllerBase
    {
        private readonly IEntraGroupService _entraGroupService;
        private readonly ILogger<EntraGroupsController> _logger;
        private readonly IEntraGroupDal _entraGroupDal;
        public EntraGroupsController(IEntraGroupDal entraGroupDal)
        {
            _entraGroupDal = entraGroupDal;
        }

        public EntraGroupsController(IEntraGroupService entraGroupService, ILogger<EntraGroupsController> logger)
        {
            _entraGroupService = entraGroupService;
            _logger = logger;
        }

        [Route("get")]
        [HttpGet]
        public EntraGroup GetById(string id)
        {
            using (ReportDataBackendContext context = new ReportDataBackendContext())
            {
                var groupDetails = context.Set<EntraGroup>().Include(t => t.EntraUserAccounts).ThenInclude(t => t.DbUserAccount).SingleOrDefault(t => t.AzGroupId == id);
                return groupDetails == null ? new EntraGroup() : groupDetails;
            }
        }

        [Route("getall")]
        [HttpGet]
        public List<EntraGroup> GetAll()
        {
            return _entraGroupDal.GetAll();
        }
    }
}
