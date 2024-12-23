﻿using Microsoft.AspNetCore.Mvc;
using ReportDataBackend.Business.Abstract;
using ReportDataBackend.Entity.Concrete;

namespace ReportDataBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntraServicePrincipalsController : ControllerBase
    {
        private readonly IEntraServicePrincipalService _entraServicePrincipalService;
        private readonly ILogger<EntraServicePrincipalsController> _logger;


        public EntraServicePrincipalsController(IEntraServicePrincipalService entraServicePrincipalService, ILogger<EntraServicePrincipalsController> logger)
        {
            _entraServicePrincipalService = entraServicePrincipalService;
            _logger = logger;
        }

        [Route("get")]
        [HttpGet]
        public EntraServicePrincipal GetById(string id)
        {
            return _entraServicePrincipalService.GetById(id).Data;
        }

        [Route("getall")]
        [HttpGet]
        public List<EntraServicePrincipal> GetAll()
        {
            return _entraServicePrincipalService.GetAll().Data;
        }
    }
}
