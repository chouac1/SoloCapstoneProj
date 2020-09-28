﻿using System;
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
using Korzh.EasyQuery.Linq;

namespace SoloCapstoneProject.Controllers
{
    public class ConsumersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IRepositoryWrapper _repo;
        private readonly GeocodingService _geocodingService;

        public ConsumersController(ApplicationDbContext context, IRepositoryWrapper repo, GeocodingService geocodingService)
        {
            _context = context;
            _repo = repo;
            _geocodingService = geocodingService;
        }

        // GET: Consumers
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var foundId = _context.Consumers.Where(i => i.IdentityUserId == userId).SingleOrDefault();

            if (foundId == null)
            {
                return View("Create");
            }

            return View("Details", foundId);

        }

        // GET: Consumers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                RedirectToAction("Create");
            }

            var consumer = await _context.Consumers
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.ConsumerId == id);
            if (consumer == null)
            {
                return NotFound();
            }

            return View(consumer);
        }

        // GET: Consumers/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Consumers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Consumer consumer)
        {

            if (ModelState.IsValid)
            {

                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                consumer.IdentityUserId = userId;

                var consumerWithLogLat = await _geocodingService.GetGeoCoding(consumer);

                _context.Add(consumerWithLogLat);
                _repo.Save();
                return RedirectToAction(nameof(Index));
            }
            
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", consumer.IdentityUserId);
            return View("details", consumer);
        }

        // GET: Consumers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consumer = await _context.Consumers.FindAsync(id);
            if (consumer == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", consumer.IdentityUserId);
            return View(consumer);
        }

        // POST: Consumers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Consumer consumer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            consumer.IdentityUserId = userId;

            var consumerWithLogLat = await _geocodingService.GetGeoCoding(consumer);

            if (id != consumer.ConsumerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consumer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsumerExists(consumer.ConsumerId))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", consumer.IdentityUserId);
            return View(consumer);
        }

        // GET: Consumers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consumer = await _context.Consumers
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.ConsumerId == id);
            if (consumer == null)
            {
                return NotFound();
            }

            return View(consumer);
        }

        // POST: Consumers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consumer = await _context.Consumers.FindAsync(id);
            _context.Consumers.Remove(consumer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //Consumers/ConsumerList
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ConsumerList()
        {
            var applicationDbContext = _context.Consumers.Include(c => c.IdentityUser);

            
            return View(await applicationDbContext.ToListAsync());

        }

        public async Task<IActionResult> ProviderList(string searchString)
        {
            var providers = from m in _context.Providers
                            select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                providers = providers.Where(s => s.Services.Contains(searchString));
            }

            return View(await providers.ToListAsync());
        }

        private bool ConsumerExists(int id)
        {
            return _context.Consumers.Any(e => e.ConsumerId == id);
        }
    }
}
