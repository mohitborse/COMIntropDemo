using Microsoft.AspNetCore.Mvc;

namespace WebApiComClient.Controllers
{
    [ApiController]
    [Route("api/communication")]
    public class CommunicationController : ControllerBase
    {
        private static readonly dynamic? comObj;

        static CommunicationController()
        {
            Type type = Type.GetTypeFromProgID("DesktopComServer.Communication");
            comObj = Activator.CreateInstance(type);
        }

        [HttpPost("send-to-desktop")]
        public IActionResult SendToDesktop([FromBody] string message)
        {
            //var type = Type.GetTypeFromProgID("DesktopComServer.Communication");
            //dynamic comObj = Activator.CreateInstance(type);
            comObj.NotifyFromWeb(message);
            return Ok();
        }

        [HttpGet("fetch-from-desktop")]
        public IActionResult FetchFromDesktop()
        {
            //var type = Type.GetTypeFromProgID("DesktopComServer.Communication");
            //dynamic comObj = Activator.CreateInstance(type);
            string result = comObj.FetchDesktopUpdates();
            return Ok(result);
        }
    }
}
