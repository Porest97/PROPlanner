using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROPlanner.Models;
using PROPlanner.Models.DataModels;

namespace PROPlanner.Controllers.HockeyGameControllers
{
    public class GamesController : Controller
    {
        private readonly PROPlannerContext _context;

        public GamesController(PROPlannerContext context)
        {
            _context = context;
        }

        // GET: Games
        public async Task<IActionResult> Index()
        {
            var pROPlannerContext = _context.Game.Include(g => g.Arena).Include(g => g.AwayTeam).Include(g => g.GameCategory).Include(g => g.HD1).Include(g => g.HD2).Include(g => g.HomeTeam).Include(g => g.LD1).Include(g => g.LD2);
            return View(await pROPlannerContext.ToListAsync());
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .Include(g => g.Arena)
                .Include(g => g.AwayTeam)
                .Include(g => g.GameCategory)
                .Include(g => g.HD1)
                .Include(g => g.HD2)
                .Include(g => g.HomeTeam)
                .Include(g => g.LD1)
                .Include(g => g.LD2)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName");
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "TeamName");
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "Id", "GameCategoryName");
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName");
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "FullName");
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GameCategoryId,GameNumber,GameDateTime,ArenaId,TeamId,TeamId1,HomeTeamScore,AwayTeamScore,PersonId,PersonId1,PersonId2,PersonId3,HD1Fee,HD1TravelKost,HD1Alowens,HD1LateGameKost,HD1TotalFee,HD2Fee,HD2TravelKost,HD2Alowens,HD2LateGameKost,HD2TotalFee,LD1Fee,LD1TravelKost,LD1Alowens,LD1LateGameKost,LD1TotalFee,LD2Fee,LD2TravelKost,LD2Alowens,LD2LateGameKost,LD2TotalFee,GameTotalKost")] Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", game.ArenaId);
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "TeamName", game.TeamId1);
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "Id", "GameCategoryName", game.GameCategoryId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", game.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", game.PersonId1);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", game.TeamId);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName", game.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "FullName", game.PersonId3);
            return View(game);
        }

        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", game.ArenaId);
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "TeamName", game.TeamId1);
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "Id", "GameCategoryName", game.GameCategoryId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", game.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", game.PersonId1);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", game.TeamId);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName", game.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "FullName", game.PersonId3);
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GameCategoryId,GameNumber,GameDateTime,ArenaId,TeamId,TeamId1,HomeTeamScore,AwayTeamScore,PersonId,PersonId1,PersonId2,PersonId3,HD1Fee,HD1TravelKost,HD1Alowens,HD1LateGameKost,HD1TotalFee,HD2Fee,HD2TravelKost,HD2Alowens,HD2LateGameKost,HD2TotalFee,LD1Fee,LD1TravelKost,LD1Alowens,LD1LateGameKost,LD1TotalFee,LD2Fee,LD2TravelKost,LD2Alowens,LD2LateGameKost,LD2TotalFee,GameTotalKost")] Game game)
        {
            if (id != game.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.Id))
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
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", game.ArenaId);
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "TeamName", game.TeamId1);
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "Id", "GameCategoryName", game.GameCategoryId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", game.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", game.PersonId1);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", game.TeamId);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName", game.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "FullName", game.PersonId3);
            return View(game);
        }

        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .Include(g => g.Arena)
                .Include(g => g.AwayTeam)
                .Include(g => g.GameCategory)
                .Include(g => g.HD1)
                .Include(g => g.HD2)
                .Include(g => g.HomeTeam)
                .Include(g => g.LD1)
                .Include(g => g.LD2)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Game.FindAsync(id);
            _context.Game.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
            return _context.Game.Any(e => e.Id == id);
        }
    }
}
