using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ManagerController : Controller
    {
        private readonly AppDbContext _context;

        public ManagerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Manager
        public async Task<IActionResult> Index()
        {
            return View(await _context.Managers.ToListAsync());
        }



        // GET: Manager/AddOrEdit
        public IActionResult AddOrEdit(int id = 0 )
        {
            if(id==0)
            return View(new Manager());
            else
                return View(_context.Managers.Find(id));
        }


        // POST: Manager/AddOrEdit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Name,SurName")] Manager manager)
        {
            if (ModelState.IsValid)
            {
                if(manager.Id==0)
                   _context.Add(manager);
                else
                   _context.Update(manager);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(manager);
        }

        // GET: Manager/Delete/
        public async Task<IActionResult> Delete(int? id)
        {
            var manager = await _context.Managers.FindAsync(id);
            _context.Managers.Remove(manager);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       
    }
}
