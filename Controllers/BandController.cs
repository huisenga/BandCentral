using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BandCentral.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
namespace BandCentral.Controllers
{
    public class BandController : Controller
    {
        // GET: FavoriteBands
        [Route("Index")]
        [Authorize]
        public ActionResult Favorites()
        {
            
            return View(new FavoritesViewModel(System.Web.HttpContext.Current.User.Identity.GetUserId()));
        }

        [Authorize]
        public ActionResult search()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public RedirectToRouteResult addBand(string bandName)
        {
            SearchViewModel search = new SearchViewModel(System.Web.HttpContext.Current.User.Identity.GetUserId());
            search.AddBand(bandName);
            //return View("Favorites");
            return RedirectToAction("Favorites");
        }
    }
}