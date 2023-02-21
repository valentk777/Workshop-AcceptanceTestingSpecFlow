using TreeDeliveryApp.Contracts.Enitites;
using TreeDeliveryApp.Domain;
using Microsoft.AspNetCore.Mvc;

namespace TreeDeliveryApp.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TreeController : ControllerBase
    {
        private readonly ILogger<TreeController> _logger;
        private readonly ITreeDataProvider _treeDataProvider;

        public TreeController(ILogger<TreeController> logger, ITreeDataProvider treeDataProvider)
        {
            _logger = logger;
            _treeDataProvider = treeDataProvider;
        }

        [HttpGet("")]
        public List<Tree>? GetAllTrees()
        {
            var result = _treeDataProvider.GetAllTrees();
            return result.Trees;
        }

        [HttpGet("{id}")]
        public List<Tree>? GetAllTreesByType([FromRoute] int type)
        {
            var result = _treeDataProvider.GetAllTrees((TreeType)type);
            return result.Trees;
        }
    }
}
