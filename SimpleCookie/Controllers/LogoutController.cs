using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace SimpleCookie.Controllers
{
    public class LogoutController : Controller
    {
        // GET
        public async Task<IActionResult> Index()
        {
            await HttpContext.SignOutAsync();

            return Redirect("/");
        }
    }
}