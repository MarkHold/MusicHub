using FullstackCourse.Models;
using FullstackCourse.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace FullstackCourse.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _context;
        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Gigs
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                //Here we have a Linq example, since Genres does not contain properties 
                // for a tolist, we can just do .toList() for that. 
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }

    }
}