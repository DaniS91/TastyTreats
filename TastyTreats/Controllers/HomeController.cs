using Microsoft.AspNetCore.Mvc;
using TastyTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace TastyTreats.Controllers
{
  public class HomeController : Controller
  {
    private readonly TastyTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(UserManager<ApplicationUser> userManager, TastyTreatsContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Flavor[] flavs = _db.Flavors.ToArray();
      Treat[] treats = _db.Treats.ToArray();
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();
      model.Add("flavors", flavs);
      model.Add("treats", treats);
      return View(model);
    }
  }
}