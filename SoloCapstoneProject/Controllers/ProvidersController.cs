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
using SoloCapstoneProject.Services;

namespace SoloCapstoneProject.Controllers
{
    public class ProvidersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IRepositoryWrapper _repo;
        private readonly GeocodingService _geocodingService;

        public ProvidersController(ApplicationDbContext context, IRepositoryWrapper repo, GeocodingService geocodingService)
        {
            _context = context;
        }

        // GET: Providers
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var foundId = _context.Providers.Where(i => i.IdentityUserId == userId).SingleOrDefault();

            if (foundId == null)
            {
                return View("Create");
            }

            return View("Details", foundId);
        }

        // GET: Providers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", provider.IdentityUserId);
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", provider.IdentityUserId);
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", provider.IdentityUserId);
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

        public async Task<IActionResult> AvailableDates()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var foundId = _context.Providers.Where(i => i.IdentityUserId == userId).SingleOrDefault();
            var foundAvail = _context.ProviderAvailabilities.Where(f => f.ProviderId == foundId.ProviderId).SingleOrDefault();

            return View(foundAvail);
        }

        private bool ProviderExists(int id)
        {
            return _context.Providers.Any(e => e.ProviderId == id);
        }
    }
}
