using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROPlanner.Models;
using PROPlanner.Models.DataModels;

namespace PROPlanner.Controllers
{
    public class WorkingDaysController : Controller
    {
        private readonly PROPlannerContext _context;

        public WorkingDaysController(PROPlannerContext context)
        {
            _context = context;
        }

        // GET: WorkingDays
        public async Task<IActionResult> Index()
        {
            return View(await _context.WorkingDay.ToListAsync());
        }

        // GET: WorkingDays/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workingDay = await _context.WorkingDay
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workingDay == null)
            {
                return NotFound();
            }

            return View(workingDay);
        }

        // GET: WorkingDays/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WorkingDays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,WorkingDayName,WorkingDayStart,WorkingDayEnd,HoursWorked")] WorkingDay workingDay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workingDay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workingDay);
        }

        // GET: WorkingDays/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workingDay = await _context.WorkingDay.FindAsync(id);
            if (workingDay == null)
            {
                return NotFound();
            }
            return View(workingDay);
        }

        // POST: WorkingDays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WorkingDayName,WorkingDayStart,WorkingDayEnd,HoursWorked")] WorkingDay workingDay)
        {
            if (id != workingDay.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workingDay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkingDayExists(workingDay.Id))
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
            return View(workingDay);
        }

        // GET: WorkingDays/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workingDay = await _context.WorkingDay
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workingDay == null)
            {
                return NotFound();
            }

            return View(workingDay);
        }

        // POST: WorkingDays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workingDay = await _context.WorkingDay.FindAsync(id);
            _context.WorkingDay.Remove(workingDay);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkingDayExists(int id)
        {
            return _context.WorkingDay.Any(e => e.Id == id);
        }
    }
}
