using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoloCapstoneProject.Contracts;
using SoloCapstoneProject.Data;
using SoloCapstoneProject.Models;

namespace SoloCapstoneProject.Controllers
{
    public class ProviderSchedulesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IRepositoryWrapper _repo;

        public ProviderSchedulesController(ApplicationDbContext context, IRepositoryWrapper repo)
        {
            _context = context;
            _repo = repo;
        }

        // GET: ProviderAvailabilities
        public ActionResult Index()
        {
            return RedirectToAction("Details");
        }

        // GET: ProviderAvailabilities/Details/5
        public ActionResult Details(int id)
        {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var foundId = _context.Consumers.Where(i => i.IdentityUserId == userId).SingleOrDefault();

            if (foundId == null)
            {
                return RedirectToAction("Create");
            }

            return View(foundId);
        }

        // GET: ProviderAvailabilities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProviderAvailabilities/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProviderSchedule providerSchedule)
        {



            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProviderAvailabilities/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProviderAvailabilities/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProviderAvailabilities/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProviderAvailabilities/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
