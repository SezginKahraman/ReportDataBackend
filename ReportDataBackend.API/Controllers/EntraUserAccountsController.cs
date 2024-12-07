using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReportDataBackend.API.Models.Response;
using ReportDataBackend.Business.Abstract;
using ReportDataBackend.DataAccess.Concrete.EntityFramework;
using ReportDataBackend.Entity.Concrete;
using System.Data;
using System.Globalization;

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

        [Route("getbygroupid")]
        [HttpGet]
        public List<EntraUserAccountResponseModel> GetByUserId(string groupId)
        {
            using (ReportDataBackendContext context = new ReportDataBackendContext())
            {
                var entraUsers = context.Set<EntraUserAccount>().Include(t => t.EntraPimactivations).Where(t => t.AzGroupId == groupId).ToList();

                return entraUsers == null ? new List<EntraUserAccountResponseModel>() : entraUsers.Select(t => new EntraUserAccountResponseModel()
                {
                    DbUserAccountId = t.DbUserAccountId,
                    AzRoleId = t.AzRoleId,
                    AzDisplayName = t.AzDisplayName,
                    AzEnabled = t.AzEnabled,
                    AzLastActivated = GetLastActivatedDate(t),
                    AzStatus = t.AzStatus,
                    AzType = t.AzType,
                    AzUpn = t.AzUpn,
                    EntraGroupModifications = t.EntraGroupModifications?.Select(t => new EntraGroupModificationResponseModel()).ToList(),
                    EntraPimactivations = t.EntraPimactivations?.Select(t => new EntraPimactivationResponseModel()).ToList(),
                    AzGroups = t.AzGroups?.Select(t => new EntraGroupResponseModel()).ToList(),
                    AzAssignment = t.AzAssignment,
                    AzGroupId = t.AzGroupId,
                }).ToList();
            }
        }

        private string GetLastActivatedDate(EntraUserAccount userAccount)
        {
            var pimActivations = userAccount.EntraPimactivations.OrderByDescending(t => t.AzEndTime);

            if (DateTime.TryParseExact(
                    userAccount.AzLastActivated,
                    "MM/dd/yyyy hh:mm:ss tt",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime parsedDate))
            {
                DateTime now = DateTime.Now;

                TimeSpan difference = now - parsedDate;

                int roundedDays = (int)Math.Round(difference.TotalDays);

                if (roundedDays > 30)
                {
                    return $"{roundedDays}";
                }
                else
                {
                    return pimActivations.FirstOrDefault()?.AzEndTime != null ? pimActivations.FirstOrDefault()?.AzEndTime.ToString("MM/dd/yyyy hh:mm") : "No time from pim activations.";
                }
            }

            return userAccount.AzLastActivated;
        }
    }
}
