using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Enterprise_Programming_in_C_Project.Pages
{
    public class LoginModel : PageModel
    {
        private const string ValidUsername = "admin"; //Placeholder
        private const string ValidPassword = "password"; // Placeholder

        public bool IsLoginValid { get; set; } = true;

        public int CartItemCount => 0; 

        public void OnGet()
        {
        }

        public IActionResult OnPost(string username, string password)
        {
            if (username == ValidUsername && password == ValidPassword)
            {
                // Redirect to admin page upon successful login
                return RedirectToPage("/Admin");
            }

            // If login fails, keep the user on the login page
            IsLoginValid = false;
            return Page();
        }
    }
}
