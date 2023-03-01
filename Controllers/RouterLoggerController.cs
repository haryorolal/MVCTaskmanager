using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.Text;
using System.IO;

namespace MVCTaskmanager.Controllers
{
    public class RouterLoggerController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public RouterLoggerController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        [Route("api/routerlogger")]
        public IActionResult Index()    
        {
            string logMessage = null;
            using (StreamReader streamReader = new StreamReader(Request.Body, Encoding.ASCII))                
            {

                logMessage = streamReader.ReadToEnd() + "\n"; //Synchronous operations are disallowed. Call ReadAsync or set AllowSynchronousIO to true instead in startup.'
            }
            string filePath = _hostingEnvironment.ContentRootPath + "\\RouterLogger.txt";
            System.IO.File.AppendAllText(filePath, logMessage);
            return Ok();
        }
    }
}
