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
    public async Task<ActionResult> Index()
    {
      Flavor[] flavs = _db.Flavors.ToArray();
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();
      model.Add("flavors", flavs);
     
      string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      if (currentUser != null)
        {
          Treat[] treats = _db.Treats
                            .Where(entry => entry.User.Id == currentUser.Id)
                            .ToArray();
          model.Add("treats", treats);
        }
      return View(model);
    }
  }
}