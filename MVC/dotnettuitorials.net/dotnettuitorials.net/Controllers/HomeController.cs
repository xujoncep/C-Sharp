using Microsoft.AspNetCore.Mvc;
namespace dotnettuitorials.net.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public string OldIndex()
        {
            return "This is Index action from MVC Controller";
        }
    }
}
