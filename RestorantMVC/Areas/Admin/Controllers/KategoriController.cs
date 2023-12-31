﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAL.Contexts;
using Entites.Concrate;

namespace RestorantMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KategoriController : Controller
    {
        private readonly SqlDbContext _context;

        public KategoriController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Kategori
        public async Task<IActionResult> Index()
        {
              return _context.Kategoriler != null ? 
                          View(await _context.Kategoriler.ToListAsync()) :
                          Problem("Entity set 'SqlDbContext.Kategoriler'  is null.");
        }

        // GET: Admin/Kategori/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Kategoriler == null)
            {
                return NotFound();
            }

            var kategori = await _context.Kategoriler
                .FirstOrDefaultAsync(m => m.ID == id);
            if (kategori == null)
            {
                return NotFound();
            }

            return View(kategori);
        }

        // GET: Admin/Kategori/Create
        public IActionResult Create()
        {
            Kategori kategori = new();
            return View(kategori);
        }

        // POST: Admin/Kategori/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KategoriAdi,KategoriAciklama,ID,CreateTime,UpdateTime")] Kategori kategori)
        {
            if (ModelState.IsValid)
            {
                return View(kategori);
            }
            try
            {
                _context.Kategoriler.Add(kategori);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Aynı İsimde bir kategori zaten mevcut");
                return View(kategori);
            }
            return RedirectToAction("Index");
        }

        // GET: Admin/Kategori/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var kategori = _context.Kategoriler.Find(id);


            return View(kategori);
        }

        // POST: Admin/Kategori/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KategoriAdi,KategoriAciklama,ID,CreateTime,UpdateTime")] Kategori kategori)
        {
            if (ModelState.IsValid)
            {
                return View(kategori);
            }
            try
            {
                _context.Kategoriler.Update(kategori);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Aynı İsimde bir kategori zaten mevcut");
                return View(kategori);
            }
            return RedirectToAction("Index");
        }

        // GET: Admin/Kategori/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Kategoriler == null)
            {
                return NotFound();
            }

            var kategori = await _context.Kategoriler
                .FirstOrDefaultAsync(m => m.ID == id);
            if (kategori == null)
            {
                return NotFound();
            }

            return View(kategori);
        }

        // POST: Admin/Kategori/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Kategoriler == null)
            {
                return Problem("Entity set 'SqlDbContext.Kategoriler'  is null.");
            }
            var kategori = await _context.Kategoriler.FindAsync(id);
            if (kategori != null)
            {
                _context.Kategoriler.Remove(kategori);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KategoriExists(int id)
        {
          return (_context.Kategoriler?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
