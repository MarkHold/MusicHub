using FullstackCourse.Models;
using FullstackCourse.ViewModels;
using Microsoft.AspNet.Identity;
using System;
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
         
        //here we add the action for the Create file
        // [Authorize] means that only authorized users can access this method/function
        // [HttpPost] means that we want this funciton/method to only be called by an http method.
        [Authorize] 
        [HttpPost]
        public ActionResult Create(GigFormViewModel viewModel)
        {
            var artistId = User.Identity.GetUserId();
            var artist = _context.Users.Single(u => u.Id == artistId);
            var genre = _context.Genres.Single(g => g.Id == viewModel.Genre);
            var gig = new Gig
            {
                Artist = artist,
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                Genre = genre,
                Venu = viewModel.Venu
            };

            _context.Gigs.Add(gig);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}