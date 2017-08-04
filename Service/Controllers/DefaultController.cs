using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Get()
        {
            return this.Request.Headers["Cookie"].ToString();
        }

        [HttpGet]
        [Route("set-cookie")]
        public void SetCookie()
        {
            this.Response.Cookies.Append("my_cookie", "fake");
        }
    }
}
