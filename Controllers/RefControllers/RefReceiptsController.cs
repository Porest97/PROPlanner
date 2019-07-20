using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROPlanner.Models;
using PROPlanner.Models.RefModels;

namespace PROPlanner.Controllers.RefControllers
{
    public class RefReceiptsController : Controller
    {
        private readonly PROPlannerContext _context;

        public RefReceiptsController(PROPlannerContext context)
        {
            _context = context;
        }

        // GET: RefReceipts
        public async Task<IActionResult> Index()
        {
            var pROPlannerContext = _context.RefReceipt.Include(r => r.Match).Include(r => r.REF1).Include(r => r.REF2).Include(r => r.REF3).Include(r => r.REF4);
            return View(await pROPlannerContext.ToListAsync());
        }

        // GET: RefReceipts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refReceipt = await _context.RefReceipt
                .Include(r => r.Match)
                .Include(r => r.REF1)
                .Include(r => r.REF2)
                .Include(r => r.REF3)
                .Include(r => r.REF4)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refReceipt == null)
            {
                return NotFound();
            }

            return View(refReceipt);
        }

        // GET: RefReceipts/Create
        public IActionResult Create()
        {
            ViewData["MatchId"] = new SelectList(_context.Match, "Id", "MatchString");
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName");
            return View();
        }

        // POST: RefReceipts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MatchId,RefereeId,RefereeId1,RefereeId2,RefereeId3,REF1Fee,REF1Allowance,REF1LateGame,REF1TravellengthKm,REF1TravelKostperkm,REF1TravelKost,REF1Toll,REF1ParkingFee,REF1TotalPayment,REF1Paid,REF1Date,REF1Sign,REF1From,REF1To,REF2Fee,REF2Allowance,REF2LateGame,REF2TravellengthKm,REF2TravelKostperkm,REF2TravelKost,REF2Toll,REF2ParkingFee,REF2TotalPayment,REF2Paid,REF2Date,REF2Sign,REF2From,REF2To,REF3Fee,REF3Allowance,REF3LateGame,REF3TravellengthKm,REF3TravelKostperkm,REF3TravelKost,REF3Toll,REF3ParkingFee,REF3TotalPayment,REF3Paid,REF3Date,REF3Sign,REF3From,REF3To,REF4Fee,REF4Allowance,REF4LateGame,REF4TravellengthKm,REF4TravelKostperkm,REF4TravelKost,REF4Toll,REF4ParkingFee,REF4TotalPayment,REF4Paid,REF4Date,REF4Sign,REF4From,REF4To")] RefReceipt refReceipt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(refReceipt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MatchId"] = new SelectList(_context.Match, "Id", "MatchString", refReceipt.MatchId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", refReceipt.RefereeId);
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName", refReceipt.RefereeId1);
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName", refReceipt.RefereeId2);
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName", refReceipt.RefereeId3);
            return View(refReceipt);
        }

        // GET: RefReceipts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refReceipt = await _context.RefReceipt.FindAsync(id);
            if (refReceipt == null)
            {
                return NotFound();
            }
            ViewData["MatchId"] = new SelectList(_context.Match, "Id", "MatchString", refReceipt.MatchId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", refReceipt.RefereeId);
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName", refReceipt.RefereeId1);
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName", refReceipt.RefereeId2);
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName", refReceipt.RefereeId3);
            return View(refReceipt);
        }

        // POST: RefReceipts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MatchId,RefereeId,RefereeId1,RefereeId2,RefereeId3,REF1Fee,REF1Allowance,REF1LateGame,REF1TravellengthKm,REF1TravelKostperkm,REF1TravelKost,REF1Toll,REF1ParkingFee,REF1TotalPayment,REF1Paid,REF1Date,REF1Sign,REF1From,REF1To,REF2Fee,REF2Allowance,REF2LateGame,REF2TravellengthKm,REF2TravelKostperkm,REF2TravelKost,REF2Toll,REF2ParkingFee,REF2TotalPayment,REF2Paid,REF2Date,REF2Sign,REF2From,REF2To,REF3Fee,REF3Allowance,REF3LateGame,REF3TravellengthKm,REF3TravelKostperkm,REF3TravelKost,REF3Toll,REF3ParkingFee,REF3TotalPayment,REF3Paid,REF3Date,REF3Sign,REF3From,REF3To,REF4Fee,REF4Allowance,REF4LateGame,REF4TravellengthKm,REF4TravelKostperkm,REF4TravelKost,REF4Toll,REF4ParkingFee,REF4TotalPayment,REF4Paid,REF4Date,REF4Sign,REF4From,REF4To")] RefReceipt refReceipt)
        {
            if (id != refReceipt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(refReceipt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RefReceiptExists(refReceipt.Id))
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
            ViewData["MatchId"] = new SelectList(_context.Match, "Id", "MatchString", refReceipt.MatchId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", refReceipt.RefereeId);
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName", refReceipt.RefereeId1);
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName", refReceipt.RefereeId2);
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName", refReceipt.RefereeId3);
            return View(refReceipt);
        }

        // GET: RefReceipts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refReceipt = await _context.RefReceipt
                .Include(r => r.Match)
                .Include(r => r.REF1)
                .Include(r => r.REF2)
                .Include(r => r.REF3)
                .Include(r => r.REF4)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refReceipt == null)
            {
                return NotFound();
            }

            return View(refReceipt);
        }

        // POST: RefReceipts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var refReceipt = await _context.RefReceipt.FindAsync(id);
            _context.RefReceipt.Remove(refReceipt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RefReceiptExists(int id)
        {
            return _context.RefReceipt.Any(e => e.Id == id);
        }
    }
}
