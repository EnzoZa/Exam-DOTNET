using DataContracts;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace WebHost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NodeController : ControllerBase
    {
        private readonly ILogger<NodeController> _logger;

        public NodeController(ILogger<NodeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTree")]
        public IEnumerable<Node> Get()
        {
            var nodeService = new Services.NodeService();

            List<Node> tree = nodeService.getTree();

            return tree;
        }
    }
}