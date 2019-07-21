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
    public class SchedulesController : Controller
    {
        private readonly PROPlannerContext _context;

        public SchedulesController(PROPlannerContext context)
        {
            _context = context;
        }

        // GET: Schedules
        public async Task<IActionResult> Index()
        {
            var pROPlannerContext = _context.Schedule.Include(s => s.Person).Include(s => s.WorkingDay).Include(s => s.WorkingDay1).Include(s => s.WorkingDay3).Include(s => s.WorkingDay4).Include(s => s.WorkingDay5);
            return View(await pROPlannerContext.ToListAsync());
        }
        // GET: Schedules
        [HttpPost]
        public IActionResult Index(Schedule schedule)
        {
            var pROPlannerContext = _context.Schedule
                .Include(s => s.Person)
                .Include(s => s.WorkingDay)
                .Include(s => s.WorkingDay1)
                .Include(s => s.WorkingDay3)
                .Include(s => s.WorkingDay4)
                .Include(s => s.WorkingDay5);
            
            return View(schedule);
        }

        // GET: Schedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule
                .Include(s => s.Person)
                .Include(s => s.WorkingDay)
                .Include(s => s.WorkingDay1)
                .Include(s => s.WorkingDay3)
                .Include(s => s.WorkingDay4)
                .Include(s => s.WorkingDay5)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // GET: Schedules/Create
        public IActionResult Create()
        {
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FirstName");
            ViewData["WorkingDayId"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes");
            ViewData["WorkingDayId1"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes");
            ViewData["WorkingDayId2"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes");
            ViewData["WorkingDayId3"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes");
            ViewData["WorkingDayId4"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes");
            return View();
        }

        // POST: Schedules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ScheduleStartDate,ScheduleEndDate,ScheduleWeek,ScheduleName,ScheduleDescription,PersonId,WorkingDayId,WorkingDayId1,WorkingDayId2,WorkingDayId3,WorkingDayId4,TotalWorkedHours")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                var pROPlannerContext = _context.Schedule.Include(s => s.Person).Include(s => s.WorkingDay).Include(s => s.WorkingDay1).Include(s => s.WorkingDay3).Include(s => s.WorkingDay4).Include(s => s.WorkingDay5);
                
                _context.Add(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FirstName", schedule.PersonId);
            ViewData["WorkingDayId"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId);
            ViewData["WorkingDayId1"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId1);
            ViewData["WorkingDayId2"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId2);
            ViewData["WorkingDayId3"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId3);
            ViewData["WorkingDayId4"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId4);
            return View(schedule);
        }

        // GET: Schedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FirstName", schedule.PersonId);
            ViewData["WorkingDayId"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId);
            ViewData["WorkingDayId1"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId1);
            ViewData["WorkingDayId2"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId2);
            ViewData["WorkingDayId3"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId3);
            ViewData["WorkingDayId4"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId4);
            return View(schedule);
        }

        // POST: Schedules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ScheduleStartDate,ScheduleEndDate,ScheduleWeek,ScheduleName,ScheduleDescription,PersonId,WorkingDayId,WorkingDayId1,WorkingDayId2,WorkingDayId3,WorkingDayId4,TotalWorkedHours")] Schedule schedule)
        {
            if (id != schedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var pROPlannerContext = _context.Schedule.Include(s => s.Person).Include(s => s.WorkingDay).Include(s => s.WorkingDay1).Include(s => s.WorkingDay3).Include(s => s.WorkingDay4).Include(s => s.WorkingDay5);
                    
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleExists(schedule.Id))
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
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FirstName", schedule.PersonId);
            ViewData["WorkingDayId"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId);
            ViewData["WorkingDayId1"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId1);
            ViewData["WorkingDayId2"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId2);
            ViewData["WorkingDayId3"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId3);
            ViewData["WorkingDayId4"] = new SelectList(_context.WorkingDay, "Id", "WorkingDayTimes", schedule.WorkingDayId4);
            return View(schedule);
        }

        // GET: Schedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule
                .Include(s => s.Person)
                .Include(s => s.WorkingDay)
                .Include(s => s.WorkingDay1)
                .Include(s => s.WorkingDay3)
                .Include(s => s.WorkingDay4)
                .Include(s => s.WorkingDay5)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schedule = await _context.Schedule.FindAsync(id);
            _context.Schedule.Remove(schedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleExists(int id)
        {
            return _context.Schedule.Any(e => e.Id == id);
        }
    }
}
