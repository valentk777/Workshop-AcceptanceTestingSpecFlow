using TreeDeliveryApp.Contracts.Enitites;
using TreeDeliveryApp.Contracts.Requests;
using TreeDeliveryApp.Contracts.Responses;
using TreeDeliveryApp.Domain;
using Microsoft.AspNetCore.Mvc;

namespace TreeDeliveryApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        private readonly ILogger<AppController> _logger;
        private readonly ITreeDataProvider _treeDataProvider;

        // ORDER AND TREE CAN BE DIFFERENT CONTROLLERS
        public AppController(ILogger<AppController> logger, ITreeDataProvider treeDataProvider)
        {
            _logger = logger;
            _treeDataProvider = treeDataProvider;
        }

        [HttpGet]
        //TODO: constants
        [Route("tree")]
        public async Task<IActionResult> GetAllTrees()
        {
            var result = _treeDataProvider.GetAllTrees();
            return Ok(result);
        }

        [HttpGet]
        [Route("tree/type")]
        public async Task<IActionResult> GetAllTreesByType([FromQuery] GetAllTreesByTypeRequest request)
        {
            var result = _treeDataProvider.GetAllTrees((TreeType)request.TreeType);
            return Ok(result);
        }

        [HttpGet]
        //TODO: constants
        [Route("order")]
        public async Task<IActionResult> GetAllOrderedTrees()
        {
            var result = _treeDataProvider.GetAllOrderedTrees();
            return Ok(result);
        }

        [HttpGet]
        [Route("order/type")]
        public async Task<IActionResult> GetAllOrdersByType([FromQuery] GetAllOrdersByTypeRequest request)
        {
            var result = _treeDataProvider.GetAllOrderedTrees((TreeType)request.Type);
            return Ok(result);
        }

        [HttpPost]
        [Route("order")]
        public async Task<IActionResult> OrderTree([FromBody] OrderTreeRequest request)
        {
            if (request.OrderedTree == null)
            {
                return Ok();
            }

            var result = _treeDataProvider.SaveTree(request.OrderedTree);

            if (result)
            {
                return Ok();
            }

            return Conflict(new EntryPointNotFoundException("results is not okay"));
        }
    }
}
