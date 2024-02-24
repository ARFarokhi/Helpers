using Asp.Versioning;
using Helpers.Csv;
using Microsoft.AspNetCore.Mvc;
using WebApi.Resources;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [ApiVersion(ConstValues.Controller.Ver1_0)]
    [Route("api/v{version:apiVersion}/reports")]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("proper-api-route")]
        [ProducesResponseType(typeof(FileResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public FileResult GetCustomers(string brokerCode)
        {
            var response = _reportService.GetCustomers(brokerCode);
            return File(response.ToCsvByteArray(), "text/csv", "customers.csv");
        }
    }
}
