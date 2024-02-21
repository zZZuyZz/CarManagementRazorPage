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
    public class DeleteModel : PageModel
    {
        private readonly IAccountService _accountService;
        private readonly IAccountRoleService _accRoleService;

        public DeleteModel(IAccountService context)
        {
            _accountService = context;
        }

        [BindProperty]
      public Account Account { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null || _accountService.GetAccountById(id) == null)
            {
                return NotFound();
            }

            var account = _accountService.GetAccountById(id);

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

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (id == null || _accountService.GetAccountById(id) == null)
            {
                return NotFound();
            }
            else { 
                _accountService.DeleteAccount(id);
            }

            return RedirectToPage("./Index");
        }
    }
}
