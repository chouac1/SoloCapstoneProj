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
using SQLitePCL;

namespace SoloCapstoneProject.Controllers
{
    public class OrdersController : Controller
    {

        private readonly ApplicationDbContext _context;
        private IRepositoryWrapper _repo;

        public OrdersController(ApplicationDbContext context, IRepositoryWrapper repo)
        {
            _context = context;
            _repo = repo;
        }

        // GET: OrdersController
        public ActionResult Index(int id)
        {
            Provider foundProvider = _context.Providers.Where(p => p.ProviderId == id).SingleOrDefault();
            Order orderFound = new Order();
            orderFound.ProviderId = foundProvider.ProviderId;

            return View("Create", orderFound);
        }

        // GET: OrdersController/Details/5
        public ActionResult ConsumerDetails()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var foundConsumer = _context.Consumers.Where(f => f.IdentityUserId == userId).SingleOrDefault();

            return View(foundConsumer);
        }

        // GET: OrdersController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: OrdersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int id, Order order)
        {

            id = 4;
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var foundConsumer = _context.Consumers.Where(f => f.IdentityUserId == userId).SingleOrDefault();
            order.ConsumerId = foundConsumer.ConsumerId;
            order.ProviderId = id;

            _context.Add(order);
            _repo.Order.Save();
            
            return RedirectToAction("OrderReview",order);

        }

        public ActionResult OrderReview()
        {
            return View();
        }

        // GET: OrdersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrdersController/Edit/5
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

        // GET: OrdersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrdersController/Delete/5
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
