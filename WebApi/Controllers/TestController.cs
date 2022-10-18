using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;

namespace webApi.Controllers
{
    [OpenApiTag("Test", Description = "Controller 註解")]
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        /// <summary>
        /// 取得測試資料
        /// </summary>
        /// <returns></returns>
        
        [HttpGet]
        public string Get() 
        {
            return "test api";
        }
    }
}
