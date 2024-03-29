﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BO.Models;
using CarManagementService;
using Microsoft.AspNetCore.Authentication;

namespace CarManagementUI.Pages.AdminPages
{
    public class IndexModel : PageModel
    {
        private readonly IAccountService _accountService;

        public IndexModel(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IList<Account> Account { get;set; } = default!;
        [BindProperty]
        public string SearchKey { get; set; }

        public async Task OnGetAsync()
        {
            Account = new List<Account>();
            Account = _accountService.GetAccounts().ToList();
        }
        public async Task<IActionResult> OnPostLogoutAsync()
        {
            HttpContext.Session.Clear();
            return RedirectToPage("/Login");
        }
        public IActionResult OnPost()
        {
            if (SearchKey == null)
            {
                return RedirectToAction("./index");
            }
            Account = new List<Account>();
            Account = _accountService.GetAccounts().Where(x => x.UserName.Contains(SearchKey)).ToList();
            return Page();
        }

    }
}
