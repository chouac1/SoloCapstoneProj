using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SoloCapstoneProject.Contracts;
using SoloCapstoneProject.Data;
using SoloCapstoneProject.Models;
using SoloCapstoneProject.Services;

namespace SoloCapstoneProject.Controllers
{
    public class ProvidersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IRepositoryWrapper _repo;

        public ProvidersController(ApplicationDbContext context, IRepositoryWrapper repo)
        {
            _context = context;
            _repo = repo;
        }

        [Authorize(Roles = "Provider")]

        // GET: Providers
        public async Task<IActionResult> Index()
        {

            return RedirectToAction("Dashboard");
        }

        public async Task<IActionResult> Dashboard(int? id)
        {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var foundProvider = _context.Providers.Where(i => i.IdentityUserId == userId).SingleOrDefault();


            if (foundProvider == null)
            {
                return RedirectToAction("Create");
            }

            return View(foundProvider);
        }


        public async Task<IActionResult> ListOfProviders(string searchString)
        {
            var providers = from m in _context.Providers
                            select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                providers = providers.Where(s => s.Services.Contains(searchString));

            }

            return View(await providers.ToListAsync());


        }

        // GET: Providers/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var foundId = _context.Consumers.Where(i => i.IdentityUserId == userId).SingleOrDefault();


            if (foundId == null)
            {
                RedirectToAction("Create");
            }

            var provider = await _context.Providers
                .Include(p => p.IdentityUser)
                .FirstOrDefaultAsync(m => m.ProviderId == id);
            
            if (provider == null)
            {
                return NotFound();
            }

            return View(provider);
        }

        // GET: Providers/Create
        public IActionResult Create()
        {

            return View();
        }

        // POST: Providers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Provider provider)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                provider.IdentityUserId = userId;

                _context.Add(provider);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }

            return View(provider);
        }

        // GET: Providers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provider = await _context.Providers.FindAsync(id);
            if (provider == null)
            {
                return NotFound();
            }

            return View(provider);
        }

        // POST: Providers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Provider provider)
        {
            if (id != provider.ProviderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    provider.IdentityUserId = userId;

                    _context.Update(provider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProviderExists(provider.ProviderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(provider);
        }

        // GET: Providers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provider = await _context.Providers
                .Include(p => p.IdentityUser)
                .FirstOrDefaultAsync(m => m.ProviderId == id);
            if (provider == null)
            {
                return NotFound();
            }

            return View(provider);
        }

        // POST: Providers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var provider = await _context.Providers.FindAsync(id);
            _context.Providers.Remove(provider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Schedule(int? id)
        {

            var matchingProvider = _context.ProviderSchedule.Where(p => p.ProviderId == id);

            return View(matchingProvider);
        }

        public ActionResult BookAppointment(int? id)
        {
            return View();
        }

        private bool ProviderExists(int id)
        {
            return _context.Providers.Any(e => e.ProviderId == id);
        }
    }
}
