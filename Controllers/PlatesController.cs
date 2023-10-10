using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcPlate.Data;
using MvcPlate.Models;

namespace MvcPlate.Controllers
{
    public class PlatesController : Controller
    {
        private readonly MvcPlateContext _context;

        public PlatesController(MvcPlateContext context)
        {
            _context = context;
        }

        // GET: Plates
        public async Task<IActionResult> Index()
        {
            return View(await _context.Plate.ToListAsync());
        }

        // GET: Plates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plate = await _context.Plate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plate == null)
            {
                return NotFound();
            }

            return View(plate);
        }

        // GET: Plates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Plates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,StockDate,Description,Origen,Color,Size,Price,Rating")] Plate plate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plate);
        }

        // GET: Plates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plate = await _context.Plate.FindAsync(id);
            if (plate == null)
            {
                return NotFound();
            }
            return View(plate);
        }

        // POST: Plates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,StockDate,Description,Origen,Color,Size,Price,Rating")] Plate plate)
        {
            if (id != plate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlateExists(plate.Id))
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
            return View(plate);
        }

        // GET: Plates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plate = await _context.Plate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plate == null)
            {
                return NotFound();
            }

            return View(plate);
        }

        // POST: Plates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plate = await _context.Plate.FindAsync(id);
            _context.Plate.Remove(plate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlateExists(int id)
        {
            return _context.Plate.Any(e => e.Id == id);
        }
    }
}
