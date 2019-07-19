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
    public class MatchesController : Controller
    {
        private readonly PROPlannerContext _context;

        public MatchesController(PROPlannerContext context)
        {
            _context = context;
        }

        // GET: Matches
        public async Task<IActionResult> Index()
        {
            var pROPlannerContext = _context.Match.Include(m => m.Arena).Include(m => m.AwayTeam).Include(m => m.GameCategory).Include(m => m.HD1).Include(m => m.HD2).Include(m => m.HomeTeam).Include(m => m.LD1).Include(m => m.LD2);
            return View(await pROPlannerContext.ToListAsync());
        }

        // GET: Matches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var match = await _context.Match
                .Include(m => m.Arena)
                .Include(m => m.AwayTeam)
                .Include(m => m.GameCategory)
                .Include(m => m.HD1)
                .Include(m => m.HD2)
                .Include(m => m.HomeTeam)
                .Include(m => m.LD1)
                .Include(m => m.LD2)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (match == null)
            {
                return NotFound();
            }

            return View(match);
        }

        // GET: Matches/Create
        public IActionResult Create()
        {
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName");
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "TeamName");
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "Id", "GameCategoryName");
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName");
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName");
            return View();
        }

        // POST: Matches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TSMNumber,GameCategoryId,GameNumber,GameDateTime,ArenaId,TeamId,TeamId1,HomeTeamScore,AwayTeamScore,RefereeId,RefereeId1,RefereeId2,RefereeId3,Played,Payed")] Match match)
        {
            if (ModelState.IsValid)
            {
                _context.Add(match);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", match.ArenaId);
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "TeamName", match.TeamId1);
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "Id", "GameCategoryName", match.GameCategoryId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", match.RefereeId);
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName", match.RefereeId1);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", match.TeamId);
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName", match.RefereeId2);
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName", match.RefereeId3);
            return View(match);
        }

        // GET: Matches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var match = await _context.Match.FindAsync(id);
            if (match == null)
            {
                return NotFound();
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", match.ArenaId);
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "TeamName", match.TeamId1);
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "Id", "GameCategoryName", match.GameCategoryId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", match.RefereeId);
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName", match.RefereeId1);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", match.TeamId);
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName", match.RefereeId2);
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName", match.RefereeId3);
            return View(match);
        }

        // POST: Matches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TSMNumber,GameCategoryId,GameNumber,GameDateTime,ArenaId,TeamId,TeamId1,HomeTeamScore,AwayTeamScore,RefereeId,RefereeId1,RefereeId2,RefereeId3,Played,Payed")] Match match)
        {
            if (id != match.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(match);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatchExists(match.Id))
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
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", match.ArenaId);
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "TeamName", match.TeamId1);
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "Id", "GameCategoryName", match.GameCategoryId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", match.RefereeId);
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName", match.RefereeId1);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", match.TeamId);
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName", match.RefereeId2);
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName", match.RefereeId3);
            return View(match);
        }

        // GET: Matches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var match = await _context.Match
                .Include(m => m.Arena)
                .Include(m => m.AwayTeam)
                .Include(m => m.GameCategory)
                .Include(m => m.HD1)
                .Include(m => m.HD2)
                .Include(m => m.HomeTeam)
                .Include(m => m.LD1)
                .Include(m => m.LD2)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (match == null)
            {
                return NotFound();
            }

            return View(match);
        }

        // POST: Matches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var match = await _context.Match.FindAsync(id);
            _context.Match.Remove(match);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatchExists(int id)
        {
            return _context.Match.Any(e => e.Id == id);
        }
    }
}
