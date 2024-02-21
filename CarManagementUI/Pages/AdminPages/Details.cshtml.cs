using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BO.Models;
using CarManagementService;

namespace CarManagementUI.Pages.AdminPages
{
    public class DetailsModel : PageModel
    {
        private readonly IAccountService _context;

        public DetailsModel(IAccountService context)
        {
            _context = context;
        }

      public Account Account { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var account = _context.GetAccountById(id);
            if (account == null)
            {
                return NotFound();
            }
            else 
            {
                Account = account;
            }
            return Page();
        }
    }
}
