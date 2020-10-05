using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public ActionResult Index()
        {

            return View();
        }

        // GET: OrdersController/Details/5
        public ActionResult ConsumerDetails()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var foundConsumer = _context.Consumers.Where(f => f.IdentityUserId == userId).SingleOrDefault();

            return View(foundConsumer);

        }

        // GET: OrdersController/Create
        public ActionResult Create(int id)
        {

            return View();
        }

        // POST: OrdersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order order)
        {


            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var foundConsumer = _context.Consumers.Where(f => f.IdentityUserId == userId).SingleOrDefault();
            var foundProvider = _context.Providers.Where(p => p.ProviderId == 4).SingleOrDefault();
            order.ConsumerId = foundConsumer.ConsumerId;
            order.ProviderId = 4;

            _context.Add(order);
            _repo.Order.Save();

            return View("OrderReview", order);

        }

        public ActionResult OrderReview()
        {
            return View();
        }

        // GET: OrdersController/Edit/5
        public async Task<IActionResult> ConsumerEdit(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);

        }

        // POST: OrdersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConsumerEdit(int id, Order order)
        {

            var foundOldOrder = _context.Orders.Where(o => o.OrderId == id).SingleOrDefault();
            foundOldOrder.ServiceDate = order.ServiceDate;
            foundOldOrder.ConsumerComments = order.ConsumerComments;
            foundOldOrder.ProviderComments = order.ProviderComments;

            
            try
            {
                return RedirectToAction("Details",foundOldOrder);
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdersController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
                      
            if (id == null)
            {
                return NotFound();
            }

            var order = _context.Orders.Where(o => o.OrderId == id).SingleOrDefault();

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: OrdersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {

            Order order = _context.Orders.Where(o=>o.OrderId == id).SingleOrDefault();
            _context.Orders.Remove(order);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        public ActionResult ConsumerRequest(int id)
        {

            var newOrder = _context.Orders.Where(o => o.OrderId == id).SingleOrDefault();
            var matchingConsumer = _context.Orders.Where(c => c.ConsumerId == newOrder.ConsumerId);

            return View(matchingConsumer);
        }

        public ActionResult ProviderRequest(int id)
        {

            var matchingProvider = _context.Orders.Where(p => p.ProviderId == id);
            return View(matchingProvider);
        }

        public ActionResult ProvRequestDetails(int id)
        {

            var order = _context.Orders.Where(o => o.OrderId == id).SingleOrDefault();
            return View(order);

        }

        public ActionResult ConfirmedAppointment(int id)
        {
            var order = _context.Orders.Where(c => c.OrderId == id).SingleOrDefault();
            order.isAppointConfirmed = true;
            _context.SaveChanges();
            return View("ProvRequestDetails", order);

        }

        public async Task<IActionResult> ProviderEdit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);

        }

        public ActionResult ProviderEdit(int id)
        {
            Order order = new Order();
            var foundOldOrder = _context.Orders.Where(o => o.OrderId == id).SingleOrDefault();
            foundOldOrder.ProviderComments = order.ProviderComments;

            try
            {
                return RedirectToAction("ProvRequestDetails", foundOldOrder);
            }
            catch
            {
                return View();
            }

        }
    }
}
