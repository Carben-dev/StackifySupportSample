using Microsoft.AspNetCore.Antiforgery;
using StackifySupport.Controllers;

namespace StackifySupport.Web.Host.Controllers
{
    public class AntiForgeryController : StackifySupportControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
