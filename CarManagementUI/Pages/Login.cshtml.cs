using BO.Models;
using CarManagementService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarManagementUI.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }
        public readonly IAccountService _hraccountServices;
        public LoginModel(IAccountService hraccountServices)
        {
            _hraccountServices = hraccountServices;
        }
        [BindProperty]
        public Account Account { get; set; } = default!;

        public IActionResult OnPost()
        {
            var account = _hraccountServices.GetAccounts().FirstOrDefault(p => p.Email.Equals(Account.Email) && p.Password.Equals(Account.Password));
            if (account == null)
            {
                ViewData["Message"] = "You not have permission";
                return Page();
            }

            HttpContext.Session.SetInt32("Id", account.Id);

            if (account.RoleId == 1){
                return RedirectToPage("./AdminPages/Index");
            }else if (account.RoleId == 2)
            {
                return RedirectToPage("./CustomerPages/Index");
            }else if(account.RoleId == 3)
            {
                return RedirectToPage("./EvaluatorPages/Index");
            }
            else
            {
                ViewData["Message"] = "You not have permission";
                HttpContext.Session.Clear();
                return Page();
            }
        }
    }
}
