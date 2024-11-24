using Microsoft.AspNetCore.Mvc;
using ReportDataBackend.API.Models.Response;
using ReportDataBackend.Business.Abstract;
using ReportDataBackend.Entity.Concrete;
using System.Data;

namespace ReportDataBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntraUserAccountsController : ControllerBase
    {
        private readonly IEntraUserAccountService _entraUserAccountService;
        private readonly ILogger<EntraUserAccountsController> _logger;

        public EntraUserAccountsController(IEntraUserAccountService entraUserAccountService, ILogger<EntraUserAccountsController> logger)
        {
            _entraUserAccountService = entraUserAccountService;
            _logger = logger;
        }

        [Route("get")]
        [HttpGet]
        public EntraUserAccountResponseModel GetById(int id, bool withInclude)
        {
            var account = _entraUserAccountService.GetById(id, withInclude).Data;
            return new EntraUserAccountResponseModel()
            {
                DbUserAccountId = account.DbUserAccountId,
                AzRoleId = account.AzRoleId,
                AzDisplayName = account.AzDisplayName,
                AzEnabled = account.AzEnabled,
                AzLastActivated = account.AzLastActivated,
                AzStatus = account.AzStatus,
                AzType = account.AzType,
                AzUpn = account.AzUpn,
                EntraGroupModifications = account.EntraGroupModifications?.Select(t => new EntraGroupModificationResponseModel()).ToList(),
                EntraPimactivations = account.EntraPimactivations?.Select(t => new EntraPimactivationResponseModel()).ToList(),
                AzGroups = account.AzGroups?.Select(t => new EntraGroupResponseModel()).ToList(),
                AzRoles = account.AzRoles?.Select(account =>
                {
                    if (account.AzRole != null)
                    {
                        return new EntraRoleResponseModel()
                        {
                            AzRoleId = account.AzRole.AzRoleId,
                            AzRoleName = account.AzRole.AzRoleName,
                            AzRoleDescription = account.AzRole.AzRoleDescription,
                            AzStatus = account.AzRole.AzStatus,
                            DbCreatedDate = account.AzRole.DbCreatedDate,
                        };
                    }
                    return new EntraRoleResponseModel();
                }).ToList(),
                AzAssignment = account.AzAssignment,
                AzGroupId = account.AzGroupId,
            };
        }

        [Route("getall")]
        [HttpGet]
        public List<EntraUserAccountResponseModel> GetAll(bool withInclude)
        {
            var accounts = _entraUserAccountService.GetAll(withInclude).Data;    
            return accounts.Select(account => new EntraUserAccountResponseModel()
            {
                DbUserAccountId = account.DbUserAccountId,
                AzRoleId = account.AzRoleId,
                AzDisplayName = account.AzDisplayName,
                AzEnabled = account.AzEnabled,
                AzLastActivated = account.AzLastActivated,
                AzStatus = account.AzStatus,
                AzType = account.AzType,
                AzUpn = account.AzUpn,
                EntraGroupModifications = account.EntraGroupModifications?.Select(t => new EntraGroupModificationResponseModel()).ToList(),
                EntraPimactivations = account.EntraPimactivations?.Select(t => new EntraPimactivationResponseModel()).ToList(),
                AzGroups = account.AzGroups?.Select(t => new EntraGroupResponseModel()).ToList(),
                AzRoles = account.AzRoles?.Select(account =>
                {
                    if (account.AzRole != null)
                    {
                        return new EntraRoleResponseModel()
                        {
                            AzRoleId = account.AzRole.AzRoleId,
                            AzRoleName = account.AzRole.AzRoleName,
                            AzRoleDescription = account.AzRole.AzRoleDescription,
                            AzStatus = account.AzRole.AzStatus,
                            DbCreatedDate = account.AzRole.DbCreatedDate,
                        };
                    }
                    return new EntraRoleResponseModel();
                }).ToList(),
                AzAssignment = account.AzAssignment,
                AzGroupId = account.AzGroupId,
            }).ToList(); ;
        }
    }
}
