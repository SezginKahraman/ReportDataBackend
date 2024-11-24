using Microsoft.AspNetCore.Mvc;
using ReportDataBackend.API.Models.Response;
using ReportDataBackend.Business.Abstract;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ReportDataBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntraReportsController : ControllerBase
    {
        [Route("getall")]
        [HttpGet]
        public List<EntraReport> GetAll()
        {
            return new List<EntraReport> { new EntraReport{
                Id = 1,
                Name = "EntraID Privilege Role Dashboard Report",
                Description = "Role assignments and eligibility analysis",
                Date = "2024-03-15",
                Type = "Security"
            },
            new EntraReport{
                Id = 2,
                Name = "EntraID Privilege Users Dashboard Report",
                Description = "Role assignments and eligibility analysis",
                Date = "2024-03-15",
                Type = "Security"
            }, 
            new EntraReport{
                Id = 3,
                Name = "EntraID Privilege EntraUser Dashboard Report",
                Description = "Role assignments and eligibility analysis",
                Date = "2024-03-15",
                Type = "Security"
            }  };
        }
    }
}
