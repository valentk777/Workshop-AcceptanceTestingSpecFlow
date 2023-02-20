using TreeDeliveryApp.Contracts.Enitites;
using TreeDeliveryApp.Contracts.Requests;
using TreeDeliveryApp.Domain;
using Microsoft.AspNetCore.Mvc;

namespace TreeDeliveryApp.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly ITreeDataProvider _treeDataProvider;

        public OrderController(ILogger<OrderController> logger, ITreeDataProvider treeDataProvider)
        {
            _logger = logger;
            _treeDataProvider = treeDataProvider;
        }

        [HttpGet("")]
        public List<Order>? GetAllOrderedTrees()
        {
            var result = _treeDataProvider.GetAllOrderedTrees();
            return result.Orders;
        }

        [HttpGet("{type}")]
        public List<Order>? GetAllOrdersByType([FromRoute] int type)
        {
            var result = _treeDataProvider.GetAllOrderedTrees((TreeType)type);
            return result.Orders;
        }

        [HttpPost("")]
        public ActionResult OrderTree([FromBody] Order order)
        {
            if (order == null)
            {
                return Ok();
            }

            var result = _treeDataProvider.SaveTree(order);

            if (result)
            {
                return Ok();
            }

            return Conflict(new EntryPointNotFoundException("results is not okay"));
        }
    }
}
