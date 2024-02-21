using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BO.Models;
using CarManagementService;

namespace CarManagementUI.Pages.AdminPages
{
    public class CreateModel : PageModel
    {
        private readonly IAccountService _accountService;
        private readonly IAccountRoleService _accRoleService;

        public CreateModel(IAccountService accountService, IAccountRoleService accountRoleService)
        {
            _accountService = accountService;
            _accRoleService = accountRoleService;
        }

        public IActionResult OnGet()
        {
        ViewData["RoleId"] = new SelectList(_accRoleService.GetAccountRoles(), "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Account Account { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            _accountService.AddAccount(Account);
            return RedirectToPage("./Index");
        }
    }
}
