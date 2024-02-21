using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BO.Models;
using CarManagementService;
using Microsoft.Build.Experimental.ProjectCache;

namespace CarManagementUI.Pages.AdminPages
{
    public class EditModel : PageModel
    {
        private readonly IAccountService _context;
        private readonly IAccountRoleService _roleService;
        public EditModel(IAccountService context, IAccountRoleService roleService)
        {
            _context = context;
            _roleService = roleService;
        }

        [BindProperty]
        public Account Account { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var account = _context.GetAccountById(id);
            if (account == null)
            {
                return NotFound();
            }
            Account = account;
           ViewData["RoleId"] = new SelectList(_roleService.GetAccountRoles(), "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (_context.UpdateAccount(Account))
                {
                    return RedirectToPage("./Index", new { timestamp = DateTime.UtcNow.Ticks });
                }
                else
                {
                    return Page();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_context.GetAccountById(Account.Id) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

        }
    }
}
