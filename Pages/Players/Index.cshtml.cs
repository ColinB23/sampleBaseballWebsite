using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BrodnikProject.Data;
using BrodnikProject.Models;

namespace BrodnikProject.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly BrodnikProject.Data.BrodnikProjectContext _context;

        public IndexModel(BrodnikProject.Data.BrodnikProjectContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; }

        public async Task OnGetAsync()
        {
            Player = await _context.Player.ToListAsync();
        }
    }
}
