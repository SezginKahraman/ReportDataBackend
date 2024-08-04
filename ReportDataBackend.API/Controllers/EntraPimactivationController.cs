﻿using Microsoft.AspNetCore.Mvc;
using ReportDataBackend.Business.Abstract;
using ReportDataBackend.Entity.Concrete;

namespace ReportDataBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntraPimactivationController : ControllerBase
    {
        private readonly IEntraPimactivationService _entraPimactivationService;
        private readonly ILogger<EntraPimactivationController> _logger;


        public EntraPimactivationController(IEntraPimactivationService entraPimactivationService, ILogger<EntraPimactivationController> logger)
        {
            _entraPimactivationService = entraPimactivationService;
            _logger = logger;
        }

        [Route("get")]
        [HttpGet]
        public EntraPimactivation GetById(int id)
        {
            return _entraPimactivationService.GetById(id).Data;
        }

        [Route("getall")]
        [HttpGet]
        public List<EntraPimactivation> GetAll()
        {
            return _entraPimactivationService.GetAll().Data;
        }
    }
}
