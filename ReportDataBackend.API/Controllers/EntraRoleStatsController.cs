using Microsoft.AspNetCore.Mvc;
using ReportDataBackend.API.Models.Response;
using ReportDataBackend.Business.Abstract;

namespace ReportDataBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntraRoleStatsController : ControllerBase
    {
        private readonly IEntraRoleStatService _entraRoleStatService;
        private readonly ILogger<EntraRolesController> _logger;

        public EntraRoleStatsController(IEntraRoleStatService entraRoleStatService, ILogger<EntraRolesController> logger)
        {
            _entraRoleStatService = entraRoleStatService;
            _logger = logger;
        }

        [Route("get")]
        [HttpGet]
        public EntraRoleStatResponseModel GetById(int id, bool withInclude)
        {
            var relatedRole = _entraRoleStatService.GetById(id, withInclude).Data;
            return new EntraRoleStatResponseModel()
            {
                Assigned = relatedRole.Assigned,
                DbModifiedDate = relatedRole.DbModifiedDate,
                DbRSID = relatedRole.DbRSID,
                AzRoleId = relatedRole.AzRoleId,
                Eligible = relatedRole.Eligible,
                AzRole = relatedRole.AzRole != null ? new EntraRoleResponseModel(){
                    AzRoleId =  relatedRole.AzRole?.AzRoleId,
                    AzRoleName = relatedRole.AzRole?.AzRoleName,
                    AzRoleDescription = relatedRole.AzRole?.AzRoleDescription,
                    AzStatus = relatedRole.AzRole?.AzStatus,
                    DbCreatedDate = (DateTime)(relatedRole.AzRole?.DbCreatedDate),
                    DbModifiedDate = (DateTime)(relatedRole.AzRole?.DbModifiedDate),
                } : new EntraRoleResponseModel()
            };
        }

        [Route("getall")]
        [HttpGet]
        public List<EntraRoleStatResponseModel> GetAll(bool withInclude, int pageSize, int pageIndex)
        {
            var roleStats = pageSize > 0 ? _entraRoleStatService.GetAll(withInclude, pageSize:pageSize, pageIndex:pageIndex).Data : _entraRoleStatService.GetAll(withInclude).Data;
            return roleStats.Select(relatedRole => new EntraRoleStatResponseModel()
            {
                Assigned = relatedRole.Assigned,
                DbModifiedDate = relatedRole.DbModifiedDate,
                DbRSID = relatedRole.DbRSID,
                AzRoleId = relatedRole.AzRoleId,
                Eligible = relatedRole.Eligible,
                RoleName = relatedRole.AzRole?.AzRoleName,
                AzRole = relatedRole.AzRole != null ? new EntraRoleResponseModel()
                {
                    AzRoleId = relatedRole.AzRole?.AzRoleId,
                    AzRoleName = relatedRole.AzRole?.AzRoleName,
                    AzRoleDescription = relatedRole.AzRole?.AzRoleDescription,
                    AzStatus = relatedRole.AzRole?.AzStatus,
                    DbCreatedDate = (DateTime)(relatedRole.AzRole?.DbCreatedDate),
                    DbModifiedDate = (DateTime)(relatedRole.AzRole?.DbModifiedDate),
                } : new EntraRoleResponseModel()
            }).ToList();
        }
    }
}
