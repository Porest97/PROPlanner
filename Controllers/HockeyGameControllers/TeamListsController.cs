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
    public class TeamListsController : Controller
    {
        private readonly PROPlannerContext _context;

        public TeamListsController(PROPlannerContext context)
        {
            _context = context;
        }

        // GET: TeamLists
        public async Task<IActionResult> Index()
        {
            var pROPlannerContext = _context.TeamList
                .Include(t => t.AssCoach)
                .Include(t => t.Defense1)
                .Include(t => t.Defense2)
                .Include(t => t.Defense3)
                .Include(t => t.Defense4)
                .Include(t => t.Defense5)
                .Include(t => t.Defense6)
                .Include(t => t.Defense7)
                .Include(t => t.Defense8)
                .Include(t => t.Goalie1)
                .Include(t => t.Goalie2)
                .Include(t => t.HeadCoach)
                .Include(t => t.Offense1)
                .Include(t => t.Offense10)
                .Include(t => t.Offense11)
                .Include(t => t.Offense12)
                .Include(t => t.Offense2)
                .Include(t => t.Offense3)
                .Include(t => t.Offense4)
                .Include(t => t.Offense5)
                .Include(t => t.Offense6)
                .Include(t => t.Offense7)
                .Include(t => t.Offense8)
                .Include(t => t.Offense9)
                .Include(t => t.Team)
                .Include(t => t.TeamLeader);
            return View(await pROPlannerContext.ToListAsync());
        }

        // GET: TeamLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamList = await _context.TeamList
                .Include(t => t.AssCoach)
                .Include(t => t.Defense1)
                .Include(t => t.Defense2)
                .Include(t => t.Defense3)
                .Include(t => t.Defense4)
                .Include(t => t.Defense5)
                .Include(t => t.Defense6)
                .Include(t => t.Defense7)
                .Include(t => t.Defense8)
                .Include(t => t.Goalie1)
                .Include(t => t.Goalie2)
                .Include(t => t.HeadCoach)
                .Include(t => t.Offense1)
                .Include(t => t.Offense10)
                .Include(t => t.Offense11)
                .Include(t => t.Offense12)
                .Include(t => t.Offense2)
                .Include(t => t.Offense3)
                .Include(t => t.Offense4)
                .Include(t => t.Offense5)
                .Include(t => t.Offense6)
                .Include(t => t.Offense7)
                .Include(t => t.Offense8)
                .Include(t => t.Offense9)
                .Include(t => t.Team)
                .Include(t => t.TeamLeader)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamList == null)
            {
                return NotFound();
            }

            return View(teamList);
        }

        // GET: TeamLists/Create
        public IActionResult Create()
        {
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["PersonId5"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId6"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId7"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId8"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId9"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId10"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId11"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId12"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId4"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["PersonId13"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId22"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId23"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId24"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId14"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId15"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId16"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId17"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId18"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId19"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId20"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["PersonId21"] = new SelectList(_context.Person, "Id", "PlayerString");
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName");
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName");
            return View();
        }

        // POST: TeamLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TeamId,PersonId,PersonId1,PersonId2,PersonId3,PersonId4,PersonId5,PersonId6,PersonId7,PersonId8,PersonId9,PersonId10,PersonId11,PersonId12,PersonId13,PersonId14,PersonId15,PersonId16,PersonId17,PersonId18,PersonId19,PersonId20,PersonId21,PersonId22,PersonId23,PersonId24")] TeamList teamList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teamList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", teamList.PersonId1);
            ViewData["PersonId5"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId5);
            ViewData["PersonId6"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId6);
            ViewData["PersonId7"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId7);
            ViewData["PersonId8"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId8);
            ViewData["PersonId9"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId9);
            ViewData["PersonId10"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId10);
            ViewData["PersonId11"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId11);
            ViewData["PersonId12"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId12);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId3);
            ViewData["PersonId4"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId4);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", teamList.PersonId);
            ViewData["PersonId13"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId13);
            ViewData["PersonId22"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId22);
            ViewData["PersonId23"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId23);
            ViewData["PersonId24"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId24);
            ViewData["PersonId14"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId14);
            ViewData["PersonId15"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId15);
            ViewData["PersonId16"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId16);
            ViewData["PersonId17"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId17);
            ViewData["PersonId18"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId18);
            ViewData["PersonId19"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId19);
            ViewData["PersonId20"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId20);
            ViewData["PersonId21"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId21);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", teamList.TeamId);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName", teamList.PersonId2);
            return View(teamList);
        }

        // GET: TeamLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamList = await _context.TeamList.FindAsync(id);
            if (teamList == null)
            {
                return NotFound();
            }
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", teamList.PersonId1);
            ViewData["PersonId5"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId5);
            ViewData["PersonId6"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId6);
            ViewData["PersonId7"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId7);
            ViewData["PersonId8"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId8);
            ViewData["PersonId9"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId9);
            ViewData["PersonId10"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId10);
            ViewData["PersonId11"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId11);
            ViewData["PersonId12"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId12);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId3);
            ViewData["PersonId4"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId4);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", teamList.PersonId);
            ViewData["PersonId13"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId13);
            ViewData["PersonId22"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId22);
            ViewData["PersonId23"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId23);
            ViewData["PersonId24"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId24);
            ViewData["PersonId14"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId14);
            ViewData["PersonId15"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId15);
            ViewData["PersonId16"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId16);
            ViewData["PersonId17"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId17);
            ViewData["PersonId18"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId18);
            ViewData["PersonId19"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId19);
            ViewData["PersonId20"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId20);
            ViewData["PersonId21"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId21);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", teamList.TeamId);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName", teamList.PersonId2);
            return View(teamList);
        }

        // POST: TeamLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeamId,PersonId,PersonId1,PersonId2,PersonId3,PersonId4,PersonId5,PersonId6,PersonId7,PersonId8,PersonId9,PersonId10,PersonId11,PersonId12,PersonId13,PersonId14,PersonId15,PersonId16,PersonId17,PersonId18,PersonId19,PersonId20,PersonId21,PersonId22,PersonId23,PersonId24")] TeamList teamList)
        {
            if (id != teamList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teamList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamListExists(teamList.Id))
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
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", teamList.PersonId1);
            ViewData["PersonId5"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId5);
            ViewData["PersonId6"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId6);
            ViewData["PersonId7"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId7);
            ViewData["PersonId8"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId8);
            ViewData["PersonId9"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId9);
            ViewData["PersonId10"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId10);
            ViewData["PersonId11"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId11);
            ViewData["PersonId12"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId12);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId3);
            ViewData["PersonId4"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId4);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", teamList.PersonId);
            ViewData["PersonId13"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId13);
            ViewData["PersonId22"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId22);
            ViewData["PersonId23"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId23);
            ViewData["PersonId24"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId24);
            ViewData["PersonId14"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId14);
            ViewData["PersonId15"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId15);
            ViewData["PersonId16"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId16);
            ViewData["PersonId17"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId17);
            ViewData["PersonId18"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId18);
            ViewData["PersonId19"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId19);
            ViewData["PersonId20"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId20);
            ViewData["PersonId21"] = new SelectList(_context.Person, "Id", "PlayerString", teamList.PersonId21);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", teamList.TeamId);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName", teamList.PersonId2);
            return View(teamList);
        }

        // GET: TeamLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamList = await _context.TeamList
                .Include(t => t.AssCoach)
                .Include(t => t.Defense1)
                .Include(t => t.Defense2)
                .Include(t => t.Defense3)
                .Include(t => t.Defense4)
                .Include(t => t.Defense5)
                .Include(t => t.Defense6)
                .Include(t => t.Defense7)
                .Include(t => t.Defense8)
                .Include(t => t.Goalie1)
                .Include(t => t.Goalie2)
                .Include(t => t.HeadCoach)
                .Include(t => t.Offense1)
                .Include(t => t.Offense10)
                .Include(t => t.Offense11)
                .Include(t => t.Offense12)
                .Include(t => t.Offense2)
                .Include(t => t.Offense3)
                .Include(t => t.Offense4)
                .Include(t => t.Offense5)
                .Include(t => t.Offense6)
                .Include(t => t.Offense7)
                .Include(t => t.Offense8)
                .Include(t => t.Offense9)
                .Include(t => t.Team)
                .Include(t => t.TeamLeader)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamList == null)
            {
                return NotFound();
            }

            return View(teamList);
        }

        // POST: TeamLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teamList = await _context.TeamList.FindAsync(id);
            _context.TeamList.Remove(teamList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamListExists(int id)
        {
            return _context.TeamList.Any(e => e.Id == id);
        }
    }
}
