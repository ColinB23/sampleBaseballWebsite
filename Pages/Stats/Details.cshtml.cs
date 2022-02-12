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
    public class DetailsModel : PageModel
    {
        private readonly BrodnikProject.Data.BrodnikProjectContext _context;

        public DetailsModel(BrodnikProject.Data.BrodnikProjectContext context)
        {
            _context = context;
        }

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
    }
}
