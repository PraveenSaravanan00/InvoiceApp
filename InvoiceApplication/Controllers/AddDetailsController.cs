using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InvoiceApplication.Data;
using InvoiceApplication.Models;

namespace InvoiceApplication.Controllers
{
    public class AddDetailsController : Controller
    {
        private readonly InvoiceApplicationContext _context;

        public AddDetailsController(InvoiceApplicationContext context)
        {
            _context = context;
        }

        // GET: AddDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.AddDetails.ToListAsync());
        }

        // GET: AddDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addDetails = await _context.AddDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addDetails == null)
            {
                return NotFound();
            }

            return View(addDetails);
        }

        // GET: AddDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AddDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ItemName,Price,Gst")] AddDetails addDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addDetails);
        }

        // GET: AddDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addDetails = await _context.AddDetails.FindAsync(id);
            if (addDetails == null)
            {
                return NotFound();
            }
            return View(addDetails);
        }

        // POST: AddDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ItemName,Price,Gst")] AddDetails addDetails)
        {
            if (id != addDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddDetailsExists(addDetails.Id))
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
            return View(addDetails);
        }

        // GET: AddDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addDetails = await _context.AddDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addDetails == null)
            {
                return NotFound();
            }

            return View(addDetails);
        }

        // POST: AddDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var addDetails = await _context.AddDetails.FindAsync(id);
            if (addDetails != null)
            {
                _context.AddDetails.Remove(addDetails);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddDetailsExists(int id)
        {
            return _context.AddDetails.Any(e => e.Id == id);
        }
    }
}
