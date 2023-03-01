using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BorsaUsers.Data;

namespace BorsaUsers.Controllers
{
    public class TypesProductsController : Controller
    {
        private readonly BorsaDbContext _context;

        public TypesProductsController(BorsaDbContext context)
        {
            _context = context;
        }

        // GET: TypesProducts
        public async Task<IActionResult> Index()
        {
              return View(await _context.TypesProducts.ToListAsync());
        }

        // GET: TypesProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TypesProducts == null)
            {
                return NotFound();
            }

            var typesProduct = await _context.TypesProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typesProduct == null)
            {
                return NotFound();
            }

            return View(typesProduct);
        }

        // GET: TypesProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypesProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TypeName,Description,RegisteredOn")] TypesProduct typesProduct)
        {
            if (ModelState.IsValid)
            {
                typesProduct.RegisteredOn = DateTime.Now;
                _context.Add(typesProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typesProduct);
        }

        // GET: TypesProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TypesProducts == null)
            {
                return NotFound();
            }

            var typesProduct = await _context.TypesProducts.FindAsync(id);
            if (typesProduct == null)
            {
                return NotFound();
            }
            return View(typesProduct);
        }

        // POST: TypesProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TypeName,Description,RegisteredOn")] TypesProduct typesProduct)
        {
            if (id != typesProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typesProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypesProductExists(typesProduct.Id))
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
            return View(typesProduct);
        }

        // GET: TypesProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TypesProducts == null)
            {
                return NotFound();
            }

            var typesProduct = await _context.TypesProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typesProduct == null)
            {
                return NotFound();
            }

            return View(typesProduct);
        }

        // POST: TypesProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TypesProducts == null)
            {
                return Problem("Entity set 'BorsaDbContext.TypesProducts'  is null.");
            }
            var typesProduct = await _context.TypesProducts.FindAsync(id);
            if (typesProduct != null)
            {
                _context.TypesProducts.Remove(typesProduct);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypesProductExists(int id)
        {
          return _context.TypesProducts.Any(e => e.Id == id);
        }
    }
}
