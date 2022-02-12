using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BrodnikProject.Data;
using BrodnikProject.Models;

namespace BrodnikProject.Pages.Stats
{
    public class DeleteModel : PageModel
    {
        private readonly BrodnikProject.Data.BrodnikProjectContext _context;

        public DeleteModel(BrodnikProject.Data.BrodnikProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Stat Stat { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Stat = await _context.Stat.FirstOrDefaultAsync(m => m.ID == id);

            if (Stat == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Stat = await _context.Stat.FindAsync(id);

            if (Stat != null)
            {
                _context.Stat.Remove(Stat);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
