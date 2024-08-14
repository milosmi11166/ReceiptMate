using Microsoft.AspNetCore.Mvc;

namespace ReceiptMate.API.Controllers
{
    [Route("api/v1/receipts")]
    [ApiController]
    public class ReceiptsController : ControllerBase
    {
        private readonly IEnumerable<string> _receipts;

        public ReceiptsController()
        {
            _receipts = Enumerable.Range(1, 5).Select(i => Guid.NewGuid().ToString());
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _receipts;
        }
    }
}
