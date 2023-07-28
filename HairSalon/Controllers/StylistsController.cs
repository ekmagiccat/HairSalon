using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
    public class StylistsController : Controller
    {
        private readonly HairSalonContext _db;

        public StylistsController(HairSalonContextt db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<> model = _db.Stylists
                                  .ToList();
            return View(model);
        }

    }
}