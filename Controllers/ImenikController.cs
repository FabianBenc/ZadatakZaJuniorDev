using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Imenik.Models;

using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Routing;

namespace zadatakZaProgramere.Controllers
{
    public class ImenikController : Controller
    {
        private readonly ImenikContext _context;

        public ImenikController(ImenikContext context)
        {
            _context = context;
        }

        // GET: Imenik
        public async Task<IActionResult> Index(string searchString)
        {
            var k = from kon in _context.kontakti select kon;
            foreach(var item in k){
                item.telefon = await _context.telefon.Where(a => a.Kontaktiid == item.id).ToListAsync();
                // System.Diagnostics.Debug.WriteLine(item.telefon);
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                k = k.Where(s => s.ime.Contains(searchString));
                // backToIndex();
            }

            return View(k);
        }
        //<a asp-action="Index">Back to List</a>
        // public static string backToIndex(){
        //     var builder = new TagBuilder("a");

        //     builder.MergeAttribute("asp-action", "Index");
        //     builder.MergeAttributes(new RouteValueDictionary());

        //     return builder.ToString(TagRenderMode.SelfClosing);
        // }

        // GET: Imenik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kontakti = await _context.kontakti.FirstOrDefaultAsync(m => m.id == id);
            kontakti.telefon = await _context.telefon.Where(a => a.Kontaktiid == kontakti.id).ToListAsync();
            if (kontakti == null)
            {
                return NotFound();
            }

            return View(kontakti);
        }

        // GET: Imenik/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Imenik/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ime,prezime,grad,opis")] Kontakti kontakti)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kontakti);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kontakti);
        }

        // GET: Imenik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kontakti = await _context.kontakti.FindAsync(id);
            if (kontakti == null)
            {
                return NotFound();
            }
            return View(kontakti);
        }

        // POST: Imenik/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ime,prezime,grad,opis")] Kontakti kontakti)
        {
            if (id != kontakti.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kontakti);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KontaktiExists(kontakti.id))
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
            return View(kontakti);
        }

        // GET: Imenik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kontakti = await _context.kontakti
                .FirstOrDefaultAsync(m => m.id == id);
            if (kontakti == null)
            {
                return NotFound();
            }

            return View(kontakti);
        }

        // POST: Imenik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kontakti = await _context.kontakti.FindAsync(id);
            _context.kontakti.Remove(kontakti);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KontaktiExists(int id)
        {
            return _context.kontakti.Any(e => e.id == id);
        }
        
        public async Task<IActionResult> dodaj([FromBody]JObject data)
        {
            Kontakti k = data["o"].ToObject<Kontakti>();
            List<Telefon> b = new List<Telefon>(); 

            foreach(var el in data["b"]){
                System.Diagnostics.Debug.WriteLine("Gospon " + el);
                b.Add(el.ToObject<Telefon>());
            }

            _context.kontakti.Add(k);
            await _context.SaveChangesAsync();
            
            System.Diagnostics.Debug.WriteLine("Gospon " + k.id);

            var _id = k.id;
            
            foreach (var item in b){
                item.Kontaktiid = _id;
                _context.telefon.Add(item);
                _context.SaveChanges();
                //detach entity
                _context.Entry(item).State = EntityState.Detached;
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
