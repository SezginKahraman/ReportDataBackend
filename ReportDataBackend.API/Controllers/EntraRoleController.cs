﻿using Microsoft.AspNetCore.Mvc;
using ReportDataBackend.API.Models.Response;
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
        public EntraRoleResponseModel GetById(string id, bool withInclude)
        {
            var relatedRole = _entraRoleService.GetById(id, withInclude).Data;
            return new EntraRoleResponseModel()
            {
                AzRoleDescription = relatedRole.AzRoleDescription,
                AzRoleId = relatedRole.AzRoleId,
                AzRoleName = relatedRole.AzRoleName,
                AzStatus = relatedRole.AzStatus,
                DbCreatedDate = relatedRole.DbCreatedDate,
                DbModifiedDate = relatedRole.DbModifiedDate,
                EntraGroupAssignments = relatedRole.EntraGroupAssignments?.Select(t => new EntraGroupAssignmentResponseModel()).ToList(),
                EntraPimactivations = relatedRole.EntraPimactivations?.Select(t => new EntraPimactivationResponseModel()).ToList(),
                EntraServicePrincipals = relatedRole.EntraServicePrincipals?.Select(t => new EntraServicePrincipalResponseModel()).ToList(),
                EntraUserAccounts = relatedRole.EntraUserAccounts?.Select(account =>
                {
                    if(account.DbUserAccount != null)
                    {
                        return new EntraUserAccountResponseModel()
                        {
                            DbUserAccountId = account.DbUserAccount.DbUserAccountId,
                            AzRoleId = account.DbUserAccount.AzRoleId,
                            AzDisplayName = account.DbUserAccount.AzDisplayName,
                            AzEnabled = account.DbUserAccount.AzEnabled,
                            AzLastActivated = account.DbUserAccount.AzLastActivated,
                            AzStatus = account.DbUserAccount.AzStatus,
                            AzType = account.DbUserAccount.AzType,
                            AzUpn = account.DbUserAccount.AzUpn,
                            AzAssignment = account.DbUserAccount.AzAssignment,
                            AzGroupId = account.DbUserAccount.AzGroupId,
                        };
                    }
                    return new EntraUserAccountResponseModel();
                }).ToList()
            };
        }

        [Route("getall")]
        [HttpGet]
        public List<EntraRoleResponseModel> GetAll(bool withInclude)
        {
            var roles = _entraRoleService.GetAll(withInclude).Data;
            return roles.Select(relatedRole => new EntraRoleResponseModel()
            {
                AzRoleDescription = relatedRole.AzRoleDescription,
                AzRoleId = relatedRole.AzRoleId,
                AzRoleName = relatedRole.AzRoleName,
                AzStatus = relatedRole.AzStatus,
                DbCreatedDate = relatedRole.DbCreatedDate,
                DbModifiedDate = relatedRole.DbModifiedDate,
                EntraGroupAssignments = relatedRole.EntraGroupAssignments.Select(t => new EntraGroupAssignmentResponseModel()).ToList(),
                EntraPimactivations = relatedRole.EntraPimactivations.Select(t => new EntraPimactivationResponseModel()).ToList(),
                EntraServicePrincipals = relatedRole.EntraServicePrincipals.Select(t => new EntraServicePrincipalResponseModel()).ToList(),
                EntraUserAccounts = relatedRole.EntraUserAccounts?.Select(account =>
                {
                    if (account.DbUserAccount != null)
                    {
                        return new EntraUserAccountResponseModel()
                        {
                            DbUserAccountId = account.DbUserAccount.DbUserAccountId,
                            AzRoleId = account.DbUserAccount.AzRoleId,
                            AzDisplayName = account.DbUserAccount.AzDisplayName,
                            AzEnabled = account.DbUserAccount.AzEnabled,
                            AzLastActivated = account.DbUserAccount.AzLastActivated,
                            AzStatus = account.DbUserAccount.AzStatus,
                            AzType = account.DbUserAccount.AzType,
                            AzUpn = account.DbUserAccount.AzUpn,
                            AzAssignment = account.DbUserAccount.AzAssignment,
                            AzGroupId = account.DbUserAccount.AzGroupId,
                        };
                    }
                    return new EntraUserAccountResponseModel();
                }).ToList()
            }).ToList();
        }
    }
}
