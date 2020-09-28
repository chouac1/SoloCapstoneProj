﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SoloCapstoneProject.Contracts;
using SoloCapstoneProject.Data;
using SoloCapstoneProject.Models;

namespace SoloCapstoneProject.Controllers
{
    public class ProviderAvailabilitiesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IRepositoryWrapper _repo;


        public ProviderAvailabilitiesController(ApplicationDbContext context, IRepositoryWrapper repo)
        {
            _context = context;
            _repo = repo;
        }

        // GET: ProviderAvailabilities
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier); //finds logged in user
            var foundId = _context.Providers.Where(i => i.IdentityUserId == userId).SingleOrDefault(); //finds provider that matches with logged in id
            var foundProviderId = foundId.ProviderId;

            var applicationDbContext = _context.ProviderAvailabilities.Include(p => p.Providers);
            return View(applicationDbContext);
        }

        // GET: ProviderAvailabilities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerAvailability = await _context.ProviderAvailabilities
                .Include(p => p.Providers)
                .FirstOrDefaultAsync(m => m.ProviderAvailablityId == id);
            if (providerAvailability == null)
            {
                return NotFound();
            }

            return View(providerAvailability);
        }

        // GET: ProviderAvailabilities/Create
        public IActionResult Create()
        {
            ViewData["ProviderId"] = new SelectList(_context.Providers, "ProviderId", "ProviderId");
            return View();
        }

        // POST: ProviderAvailabilities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProviderAvailablityId,WeekDay,OpeningHour,ClosingHour,isAvailable,isBooked,ProviderId")] ProviderAvailability providerAvailability)
        {
            if (ModelState.IsValid)
            {
                _context.Add(providerAvailability);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProviderId"] = new SelectList(_context.Providers, "ProviderId", "ProviderId", providerAvailability.ProviderId);
            return View(providerAvailability);
        }

        // GET: ProviderAvailabilities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerAvailability = await _context.ProviderAvailabilities.FindAsync(id);
            if (providerAvailability == null)
            {
                return NotFound();
            }
            ViewData["ProviderId"] = new SelectList(_context.Providers, "ProviderId", "ProviderId", providerAvailability.ProviderId);
            return View(providerAvailability);
        }

        // POST: ProviderAvailabilities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProviderAvailablityId,WeekDay,OpeningHour,ClosingHour,isAvailable,isBooked,ProviderId")] ProviderAvailability providerAvailability)
        {
            if (id != providerAvailability.ProviderAvailablityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(providerAvailability);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProviderAvailabilityExists(providerAvailability.ProviderAvailablityId))
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
            ViewData["ProviderId"] = new SelectList(_context.Providers, "ProviderId", "ProviderId", providerAvailability.ProviderId);
            return View(providerAvailability);
        }

        // GET: ProviderAvailabilities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerAvailability = await _context.ProviderAvailabilities
                .Include(p => p.Providers)
                .FirstOrDefaultAsync(m => m.ProviderAvailablityId == id);
            if (providerAvailability == null)
            {
                return NotFound();
            }

            return View(providerAvailability);
        }

        // POST: ProviderAvailabilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var providerAvailability = await _context.ProviderAvailabilities.FindAsync(id);
            _context.ProviderAvailabilities.Remove(providerAvailability);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProviderAvailabilityExists(int id)
        {
            return _context.ProviderAvailabilities.Any(e => e.ProviderAvailablityId == id);
        }
    }
}
