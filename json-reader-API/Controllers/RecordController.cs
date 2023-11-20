using Mapping_Polyline_API_Burak_Ozgur.Models;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Mapping_Polyline_API_Burak_Ozgur.Controllers
{
    [Route("api/record")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private readonly IRecordService _recordService;
        public RecordController()
        {
            _recordService = new RecordService();
        }

        [HttpGet]
        public IActionResult GetAllRecords()
        {
            var records = _recordService.GetAllRecords();
            return Ok(records);
        }

        [HttpPost]
        public IActionResult AddRecord([FromBody] Record record)
        {
            _recordService.AddRecord(record);
            return Ok();
        }
    }
}
